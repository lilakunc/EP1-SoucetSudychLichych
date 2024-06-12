Imports System

Module Module1
    Sub Main()
        Console.WriteLine("Zadejte poèet èísel:")
        Dim pocetCisel As Integer = Convert.ToInt32(Console.ReadLine())
        Dim cisla(pocetCisel - 1) As Integer
        For i As Integer = 0 To pocetCisel - 1
            Dim cislo As Integer
            Do
                Console.WriteLine("Zadejte nezáporné èíslo " & (i + 1) & ":")
                cislo = Convert.ToInt32(Console.ReadLine())
                If cislo >= 0 Then
                    cisla(i) = cislo
                    Exit Do
                Else
                    Console.WriteLine("Zadaná hodnota musí být nezáporná. Zkus to znovu prosím.")
                End If
            Loop
        Next
        Console.WriteLine("Zadali jste následující èísla:")
        For Each cislo As Integer In cisla
            Console.WriteLine(cislo)
        Next
        Console.WriteLine("Stisknìte jakoukoli klávesu pro ukonèení programu.")
        Console.ReadKey()
    End Sub
End Module
