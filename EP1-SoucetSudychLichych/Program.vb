Imports System

Module Module1
    Sub Main()
        Console.WriteLine("Zadejte po�et ��sel:")
        Dim pocetCisel As Integer = Convert.ToInt32(Console.ReadLine())
        Dim cisla(pocetCisel - 1) As Integer
        For i As Integer = 0 To pocetCisel - 1
            Dim cislo As Integer
            Do
                Console.WriteLine("Zadejte nez�porn� ��slo " & (i + 1) & ":")
                cislo = Convert.ToInt32(Console.ReadLine())
                If cislo >= 0 Then
                    cisla(i) = cislo
                    Exit Do
                Else
                    Console.WriteLine("Zadan� hodnota mus� b�t nez�porn�. Zkus to znovu pros�m.")
                End If
            Loop
        Next
        Console.WriteLine("Zadali jste n�sleduj�c� ��sla:")
        For Each cislo As Integer In cisla
            Console.WriteLine(cislo)
        Next
        Console.WriteLine("Stiskn�te jakoukoli kl�vesu pro ukon�en� programu.")
        Console.ReadKey()
    End Sub
End Module
