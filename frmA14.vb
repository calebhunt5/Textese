Public Class frmA14
    'Creation of constants to locate indexes of specific values
    Const IDX_MAX_TRANSLATION As Integer = 1
    Const IDX_MAX_WORDS As Integer = 68
    Const IDX_WORD As Integer = 0
    Const IDX_ABRV As Integer = 1

    'Creation of valriables to hold file values and translations
    Dim dicShowing As Boolean = False
    Dim dictionaryStrings(IDX_MAX_TRANSLATION, 0) As String
    Dim dictionaryTranslations(IDX_MAX_WORDS) As Translation
    Dim idxWord As Integer = 0

    'structure that holds an english word and the abbreviation for that word
    Structure Translation
        Dim word As String
        Dim abrv As String
    End Structure

    'form load that sizes the form creates defaults for dictionaryTranslations and fills the user's translation dictionary
    Private Sub frmA14_Load(sender As Object, e As EventArgs) Handles Me.Load
        grpDictionary.Visible = False
        Size = New Size(490, 317)

        dictionaryTranslations(0).word = "DEFAULT WORD"
        dictionaryTranslations(0).abrv = "DEFAULT ABRV"
        initializeDictionaryTranslations()
        fillDictionary()
    End Sub

    'takes dictionary in or out of form
    Private Sub btnShowDictionary_Click(sender As Object, e As EventArgs) Handles btnToggleDictionary.Click
        toggleDictionary()
    End Sub

    'translates inputed english sentence and outputs textese sentence
    Private Sub btnTranslate_Click(sender As Object, e As EventArgs) Handles btnTranslate.Click
        'creates arrays for two languages and a string to output the translated sentence
        Dim englishSentence() As String = txtEnglish.Text.ToLower.Split(" "c)
        Dim texteseSentence(englishSentence.GetUpperBound(0)) As String
        Dim outputSentence As String

        For i As Integer = 0 To texteseSentence.GetUpperBound(0)
            texteseSentence(i) = englishSentence(i)
        Next

        'swaps out words that can be abbreviated
        For i As Integer = 0 To englishSentence.GetUpperBound(0)
            For j As Integer = 0 To dictionaryTranslations.GetUpperBound(0)
                If englishSentence(i) = dictionaryTranslations(j).word Then
                    texteseSentence(i) = dictionaryTranslations(j).abrv
                End If
            Next
        Next

        'turns array into a string for output
        For Each word In texteseSentence
            outputSentence = outputSentence & Space(1) & word
        Next

        'outputed translated sentence
        txtTextese.Text = outputSentence
    End Sub

    'fills dgv with words and their abbreviations
    Sub fillDictionary()
        Dim translateQuery = From translation In dictionaryTranslations
                             Order By translation.word Ascending
                             Select translation.word, translation.abrv

        dgvDictionary.DataSource = translateQuery.ToList
        dgvDictionary.CurrentCell = Nothing
        dgvDictionary.RowHeadersVisible = False

        dgvDictionary.Columns("word").HeaderText = "Full Word"
        dgvDictionary.Columns("abrv").HeaderText = "Abbreviation"

        dgvDictionary.AutoResizeColumns()
        dgvDictionary.AutoResizeRows()

    End Sub

    'gives value to array that holds translations
    Sub initializeDictionaryTranslations()
        initializeDictionaryStrings()

        For i As Integer = 0 To IDX_MAX_WORDS
            dictionaryTranslations(i).word = dictionaryStrings(IDX_WORD, i)
            dictionaryTranslations(i).abrv = dictionaryStrings(IDX_ABRV, i)
        Next
    End Sub

    'gives value to array that holds translations in strings instead of the translation structure
    Sub initializeDictionaryStrings()
        Dim allWords() As String = IO.File.ReadAllLines("Textese-1.txt")

        Dim line As String
        Dim data() As String

        For i As Integer = 0 To allWords.GetUpperBound(0)
            idxWord = i

            ReDim Preserve dictionaryStrings(IDX_MAX_TRANSLATION, idxWord)

            line = allWords(i)
            data = line.Split(","c)

            For j As Integer = 0 To data.GetUpperBound(0)
                dictionaryStrings(j, i) = data(j)
            Next j
        Next i
    End Sub

    'changes form size and makes dictionary visible or not visible
    Sub toggleDictionary()
        If dicShowing Then
            dicShowing = False

            grpDictionary.Visible = False

            Size = New Size(490, 317)
        Else
            dicShowing = True

            grpDictionary.Visible = True

            Size = New Size(775, 375)
        End If
    End Sub
End Class
