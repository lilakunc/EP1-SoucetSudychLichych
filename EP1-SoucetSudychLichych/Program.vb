Imports System

Module Module1
    Sub Main()
        Console.WriteLine("Zadejte po�et ��sel:")
        Dim pocetCisel As Integer = Convert.ToInt32(Console.ReadLine())
        Dim soucetSudych As Integer = 0
        Dim soucetLichych As Integer = 0
        For i As Integer = 0 To pocetCisel - 1
            Dim cislo As Integer
            Do
                Console.WriteLine("Zadejte nez�porn� ��slo " & (i + 1) & ":")
                cislo = Convert.ToInt32(Console.ReadLine())
                If cislo >= 0 Then
                    If cislo Mod 2 = 0 Then
                        soucetSudych += cislo
                    Else
                        soucetLichych += cislo
                    End If
                    Exit Do
                Else
                    Console.WriteLine("Zadan� hodnota mus� b�t nez�porn�. Zkus to znovu pros�m.")
                End If
            Loop
        Next
        Console.WriteLine("Sou�et sud�ch ��sel: " & soucetSudych)
        Console.WriteLine("Sou�et lich�ch ��sel: " & soucetLichych)
        Console.WriteLine("Stiskn�te jakoukoli kl�vesu pro ukon�en� programu.")
        Console.ReadKey()
    End Sub
End Module
