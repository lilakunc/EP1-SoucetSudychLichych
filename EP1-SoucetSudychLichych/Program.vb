Imports System

Module Module1
    Sub Main()
        Console.WriteLine("Zadejte poèet èísel:")
        Dim pocetCisel As Integer = Convert.ToInt32(Console.ReadLine())
        Dim soucetSudych As Integer = 0
        Dim soucetLichych As Integer = 0
        For i As Integer = 0 To pocetCisel - 1
            Dim cislo As Integer
            Do
                Console.WriteLine("Zadejte nezáporné èíslo " & (i + 1) & ":")
                cislo = Convert.ToInt32(Console.ReadLine())
                If cislo >= 0 Then
                    If cislo Mod 2 = 0 Then
                        soucetSudych += cislo
                    Else
                        soucetLichych += cislo
                    End If
                    Exit Do
                Else
                    Console.WriteLine("Zadaná hodnota musí být nezáporná. Zkus to znovu prosím.")
                End If
            Loop
        Next
        Console.WriteLine("Souèet sudých èísel: " & soucetSudych)
        Console.WriteLine("Souèet lichých èísel: " & soucetLichych)
        Console.WriteLine("Stisknìte jakoukoli klávesu pro ukonèení programu.")
        Console.ReadKey()
    End Sub
End Module
