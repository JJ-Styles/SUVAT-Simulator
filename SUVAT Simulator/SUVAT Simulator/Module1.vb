Module Module1

    Sub Main()
        Dim MenuOption As Integer
        Dim MenuOption2 As Integer
        Menu1(MenuOption)
        Console.Clear()
        Do Until MenuOption = 9
            If MenuOption = 1 Then
                DistanceMenu(MenuOption2)
                Console.Clear()
                If MenuOption2 = 1 Then
                    SWithoutV()
                    Console.Clear()
                ElseIf MenuOption2 = 2 Then
                    SWithoutA()
                    Console.Clear()
                ElseIf MenuOption2 = 3 Then
                    SWithoutT()
                    Console.Clear()
                ElseIf MenuOption2 = 8 Then
                    Menu1(MenuOption)
                    Console.Clear()
                End If
            ElseIf MenuOption = 2 Then
                IntailVelocityMenu(MenuOption2)
                Console.Clear()
                If MenuOption2 = 1 Then
                    UwithoutS()
                    Console.Clear()
                ElseIf MenuOption2 = 2 Then
                    UWithoutV()
                    Console.Clear()
                ElseIf MenuOption2 = 3 Then
                    UWIthoutA()
                    Console.Clear()
                ElseIf MenuOption2 = 4 Then
                    UWithoutT()
                    Console.Clear()
                ElseIf MenuOption2 = 8 Then
                    Menu1(MenuOption)
                    Console.Clear()
                End If
            ElseIf MenuOption = 3 Then
                FinalVelocityMenu(MenuOption2)
                Console.Clear()
                If MenuOption2 = 1 Then
                    VWithoutS()
                    Console.Clear()
                ElseIf MenuOption2 = 2 Then
                    VWithoutA()
                    Console.Clear()
                ElseIf MenuOption2 = 3 Then
                    VWithoutT()
                    Console.Clear()
                ElseIf MenuOption2 = 8 Then
                    Menu1(MenuOption)
                    Console.Clear()
                End If
            ElseIf MenuOption = 4 Then
                AccelerationMenu(MenuOption2)
                Console.Clear()
                If MenuOption2 = 1 Then
                    AWithoutS()
                    Console.Clear()
                ElseIf MenuOption2 = 2 Then
                    AWithoutV()
                    Console.Clear()
                ElseIf MenuOption2 = 3 Then
                    AWithoutT()
                    Console.Clear()
                ElseIf MenuOption2 = 8 Then
                    Menu1(MenuOption)
                    Console.Clear()
                End If
            ElseIf MenuOption = 5 Then
                TimeMenu(MenuOption2)
                Console.Clear()
                If MenuOption2 = 1 Then
                    TWithoutS()
                    Console.Clear()
                ElseIf MenuOption2 = 2 Then
                    TWithoutVandU()
                    Console.Clear()
                ElseIf MenuOption2 = 3 Then
                    TWithoutV()
                    Console.Clear()
                ElseIf MenuOption2 = 4 Then
                    TWithoutA()
                    Console.Clear()
                ElseIf MenuOption2 = 8 Then
                    Menu1(MenuOption)
                    Console.Clear()
                End If
            End If
        Loop
    End Sub
    Function Menu1(ByRef MenuOption As Integer)
        Console.WriteLine("Please enter the number of the option you would like to chose:")
        Console.WriteLine("1) Do you want to Work out S")
        Console.WriteLine("2) Do you want to Work out U")
        Console.WriteLine("3) Do you want to Work out V")
        Console.WriteLine("4) Do you want to Work out A")
        Console.WriteLine("5) Do you want to Work out T")
        Console.WriteLine("9) Exit")
        MenuOption = Console.ReadLine
        Return MenuOption
    End Function
    Function DistanceMenu(ByRef MenuOption2 As Integer)
        Console.WriteLine("You have chosen to work out Distance.")
        Console.WriteLine("Please enter one of the following options:")
        Console.WriteLine("1) Work out S without V")
        Console.WriteLine("2) Work out S without A")
        Console.WriteLine("3) Work out S without T")
        Console.WriteLine("8) Return back to the Main Menu.")
        MenuOption2 = Console.ReadLine
        Return MenuOption2
    End Function
    Function IntailVelocityMenu(ByRef MenuOption2 As Integer)
        Console.WriteLine("You have chosen to work out Intail Velocity.")
        Console.WriteLine("Please enter one of the following options:")
        Console.WriteLine("1) Work out U without S")
        Console.WriteLine("2) Work out U without V")
        Console.WriteLine("3) Work out U without A")
        Console.WriteLine("4) Work out U without T")
        Console.WriteLine("8) Return back to the Main Menu.")
        MenuOption2 = Console.ReadLine
        Return MenuOption2
    End Function
    Function FinalVelocityMenu(ByRef MenuOption2 As Integer)
        Console.WriteLine("You have chosen to work out Final Velocity.")
        Console.WriteLine("Please enter one of the following options:")
        Console.WriteLine("1) Work out V without S")
        Console.WriteLine("2) Work out V without A")
        Console.WriteLine("3) Work out V without T")
        Console.WriteLine("8) Return back to the Main Menu.")
        MenuOption2 = Console.ReadLine
        Return MenuOption2
    End Function
    Function AccelerationMenu(ByRef Menuoption2 As Integer)
        Console.WriteLine("You have chosen to work out Acceleration.")
        Console.WriteLine("Please enter one of the following options:")
        Console.WriteLine("1) Work out A without S")
        Console.WriteLine("2) Work out A without V")
        Console.WriteLine("3) Work out A without T")
        Console.WriteLine("8) Return back to the Main Menu.")
        Menuoption2 = Console.ReadLine
        Return Menuoption2
    End Function
    Function TimeMenu(ByRef MenuOption2 As Integer)
        Console.WriteLine("You have chosen to work out Time.")
        Console.WriteLine("Please enter one of the following options:")
        Console.WriteLine("1) Work out T without S")
        Console.WriteLine("2) Work out T without V (This Can Only Be If U = 0)")
        Console.WriteLine("3) Work out T without V (when U <> 0)")
        Console.WriteLine("4) Work out T without A")
        Console.WriteLine("8) Return back to the Main Menu.")
        MenuOption2 = Console.ReadLine
        Return MenuOption2
    End Function
    Sub SWithoutV()
        Dim U As Double
        Dim S As Double
        Dim A As Double
        Dim T As Double
        Console.WriteLine("Please enter the value of U")
        U = Console.ReadLine
        Console.WriteLine("Please enter the value of A")
        A = Console.ReadLine
        Console.WriteLine("Please enter the value of T")
        T = Console.ReadLine

        S = U * T + (0.5 * A * T ^ 2)
        Console.WriteLine("S is equal to: " & S & "m")
        Console.ReadKey()
    End Sub
    Sub SWithoutA()
        Dim U As Double
        Dim S As Double
        Dim V As Double
        Dim T As Double
        Console.WriteLine("Please enter the value of U")
        U = Console.ReadLine
        Console.WriteLine("Please enter the value of V")
        V = Console.ReadLine
        Console.WriteLine("Please enter the value of T")
        T = Console.ReadLine

        S = 0.5 * (U + V) * T
        Console.WriteLine("S is equal to: " & S & "m")
        Console.ReadKey()
    End Sub
    Sub SWithoutT()
        Dim U As Double
        Dim S As Double
        Dim A As Double
        Dim V As Double
        Console.WriteLine("Please enter the value of U")
        U = Console.ReadLine
        Console.WriteLine("Please enter the value of A")
        A = Console.ReadLine
        Console.WriteLine("Please enter the value of V")
        V = Console.ReadLine

        S = (V ^ 2 - U ^ 2) / (2 * A)
        Console.WriteLine("S is equal to: " & S & "m")
        Console.ReadKey()
    End Sub
    Sub UwithoutS()
        Dim U As Double
        Dim T As Double
        Dim A As Double
        Dim V As Double
        Console.WriteLine("Please enter the value of T")
        T = Console.ReadLine
        Console.WriteLine("Please enter the value of A")
        A = Console.ReadLine
        Console.WriteLine("Please enter the value of V")
        V = Console.ReadLine

        U = V - (A * T)
        Console.WriteLine("U is equal to: " & U & "m/s")
        Console.ReadKey()
    End Sub
    Sub UWithoutV()
        Dim U As Double
        Dim T As Double
        Dim A As Double
        Dim S As Double
        Console.WriteLine("Please enter the value of T")
        T = Console.ReadLine
        Console.WriteLine("Please enter the value of A")
        A = Console.ReadLine
        Console.WriteLine("Please enter the value of S")
        S = Console.ReadLine

        U = (S - (0.5 * A * T ^ 2)) / T
        Console.WriteLine("U is equal to: " & U & "m/s")
        Console.ReadKey()
    End Sub
    Sub UWIthoutA()
        Dim U As Double
        Dim T As Double
        Dim S As Double
        Dim V As Double
        Console.WriteLine("Please enter the value of T")
        T = Console.ReadLine
        Console.WriteLine("Please enter the value of S")
        S = Console.ReadLine
        Console.WriteLine("Please enter the value of V")
        V = Console.ReadLine

        U = ((2 * S) / T) - V
        Console.WriteLine("U is equal to: " & U & "m/s")
        Console.ReadKey()
    End Sub
    Sub UWithoutT()
        Dim U As Double
        Dim S As Double
        Dim A As Double
        Dim V As Double
        Console.WriteLine("Please enter the value of S")
        S = Console.ReadLine
        Console.WriteLine("Please enter the value of A")
        A = Console.ReadLine
        Console.WriteLine("Please enter the value of V")
        V = Console.ReadLine

        U = Math.Sqrt(V ^ 2 - (2 * A * S))
        Console.WriteLine("U is equal to: " & U & "m/s")
        Console.ReadKey()
    End Sub
    Sub VWithoutS()
        Dim U As Double
        Dim T As Double
        Dim A As Double
        Dim V As Double
        Console.WriteLine("Please enter the value of T")
        T = Console.ReadLine
        Console.WriteLine("Please enter the value of A")
        A = Console.ReadLine
        Console.WriteLine("Please enter the value of U")
        U = Console.ReadLine

        V = U + (A * T)
        Console.WriteLine("V is equal to: " & V & "m/s")
        Console.ReadKey()
    End Sub
    Sub VWithoutA()
        Dim U As Double
        Dim T As Double
        Dim S As Double
        Dim V As Double
        Console.WriteLine("Please enter the value of T")
        T = Console.ReadLine
        Console.WriteLine("Please enter the value of S")
        S = Console.ReadLine
        Console.WriteLine("Please enter the value of U")
        U = Console.ReadLine

        V = ((2 * S) / T) - U
        Console.WriteLine("V is equal to: " & V & "m/s")
        Console.ReadKey()
    End Sub
    Sub VWithoutT()
        Dim U As Double
        Dim S As Double
        Dim A As Double
        Dim V As Double
        Console.WriteLine("Please enter the value of S")
        S = Console.ReadLine
        Console.WriteLine("Please enter the value of A")
        A = Console.ReadLine
        Console.WriteLine("Please enter the value of U")
        U = Console.ReadLine

        V = Math.Sqrt(U ^ 2 + (2 * A * S))
        Console.WriteLine("V is equal to: " & V & "m/s")
        Console.ReadKey()
    End Sub
    Sub AWithoutS()
        Dim U As Double
        Dim T As Double
        Dim A As Double
        Dim V As Double
        Console.WriteLine("Please enter the value of T")
        T = Console.ReadLine
        Console.WriteLine("Please enter the value of V")
        V = Console.ReadLine
        Console.WriteLine("Please enter the value of U")
        U = Console.ReadLine

        A = (V - U) / T
        Console.WriteLine("A is equal to: " & A & "m/s")
        Console.ReadKey()
    End Sub
    Sub AWithoutV()
        Dim U As Double
        Dim T As Double
        Dim A As Double
        Dim S As Double
        Console.WriteLine("Please enter the value of T")
        T = Console.ReadLine
        Console.WriteLine("Please enter the value of S")
        S = Console.ReadLine
        Console.WriteLine("Please enter the value of U")
        U = Console.ReadLine

        A = (2 * (S - (U * T))) / T ^ 2
        Console.WriteLine("A is equal to: " & A & "m/s/s")
        Console.ReadKey()
    End Sub
    Sub AWithoutT()
        Dim U As Double
        Dim V As Double
        Dim A As Double
        Dim S As Double
        Console.WriteLine("Please enter the value of V")
        V = Console.ReadLine
        Console.WriteLine("Please enter the value of S")
        S = Console.ReadLine
        Console.WriteLine("Please enter the value of U")
        U = Console.ReadLine

        A = (V ^ 2 - U ^ 2) / (2 * S)
        Console.WriteLine("A is equal to: " & A & "m/s/s")
        Console.ReadKey()
    End Sub
    Sub TWithoutS()
        Dim U As Double
        Dim T As Double
        Dim A As Double
        Dim V As Double
        Console.WriteLine("Please enter the value of A")
        A = Console.ReadLine
        Console.WriteLine("Please enter the value of V")
        V = Console.ReadLine
        Console.WriteLine("Please enter the value of U")
        U = Console.ReadLine

        T = (V - U) / A
        Console.WriteLine("T is equal to: " & T & "s")
        Console.ReadKey()
    End Sub
    Sub TWithoutVandU()
        Dim T As Double
        Dim A As Double
        Dim S As Double
        Console.WriteLine("Please enter the value of A")
        A = Console.ReadLine
        Console.WriteLine("Please enter the value of S")
        S = Console.ReadLine

        T = Math.Sqrt((2 * S) / A)
        Console.WriteLine("T is equal to: " & T & "s")
        Console.ReadKey()
    End Sub
    Sub TWithoutV()
        Dim U As Double
        Dim T As Double
        Dim A As Double
        Dim S As Double
        Console.WriteLine("Please enter the value of A")
        A = Console.ReadLine
        Console.WriteLine("Please enter the value of S")
        S = Console.ReadLine
        Console.WriteLine("Please enter the value of U")
        U = Console.ReadLine

        T = (-(U / 2) + (Math.Sqrt((U / 2) ^ 2 + S))) / (0.5 * A)
        Console.WriteLine("T is equal to: " & T & "s")
        Console.ReadKey()
    End Sub
    Sub TWithoutA()
        Dim U As Double
        Dim T As Double
        Dim S As Double
        Dim V As Double
        Console.WriteLine("Please enter the value of S")
        S = Console.ReadLine
        Console.WriteLine("Please enter the value of V")
        V = Console.ReadLine
        Console.WriteLine("Please enter the value of U")
        U = Console.ReadLine

        T = (0.5 * (U + V)) / S
        Console.WriteLine("T is equal to: " & T & "s")
        Console.ReadKey()
    End Sub
End Module
