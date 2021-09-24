'Author: Casey Bement
'Date: 09/23/2021
'Purpose: Create three objects and use them

Option Strict On
Option Explicit On

Imports System.ComponentModel
Public Class frmThreeClasses

    'Module Level Objects
    Dim lstCar As New BindingList(Of Car)
    Dim lstDog As New BindingList(Of Dog)
    Dim lstPhilosopher As New BindingList(Of Philosopher)

    Private Sub btnCarCreate_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCarCreate.Click

        'Validate Data in textboxes
        If txtMake.Text <> String.Empty Then
            If txtModel.Text <> String.Empty Then
                If cboCarColor.Text <> String.Empty Then
                    'Declare Objects and Variables 
                    Dim objCar As New Car(txtMake.Text)

                    'Assign Car Properties
                    objCar.Make = txtMake.Text
                    objCar.Model = txtModel.Text
                    objCar.Color = cboCarColor.Text

                    'Process and Display Output
                    lbxCar.Text = objCar.Car_Name
                    lbxCar.Text = objCar.Color

                    'Add new Car Object to list of Cars
                    lstCar.Add(objCar)

                End If

            Else MessageBox.Show("Model cannot be blank.")
            End If
        Else MessageBox.Show("Make cannot be blank.")
        End If
    End Sub

    Private Sub frmThreeClasses_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Populate the Car Color Combobox
        cboCarColor.Items.Add("Red")
        cboCarColor.Items.Add("Black")
        cboCarColor.Items.Add("White")
        cboCarColor.Items.Add("Blue")
        cboCarColor.Items.Add("Other")

        'Select the first Car Color
        cboCarColor.SelectedIndex = 0

        'Create list of Cars
        lbxCar.DataSource = lstCar
        lbxCar.DisplayMember = "Make"

        'Populate the Dog Color Combobox
        cboDogColor.Items.Add("Brown")
        cboDogColor.Items.Add("Black")
        cboDogColor.Items.Add("White")
        cboDogColor.Items.Add("Other")

        'Select the first Dog Color
        cboDogColor.SelectedIndex = 0

        'Create list of Dogs
        lbxDog.DataSource = lstDog
        lbxDog.DisplayMember = "Breed"

        'Create list of Philosophers
        lbxPhilosopher.DataSource = lstPhilosopher
        lbxPhilosopher.DisplayMember = "Name"

    End Sub

    Private Sub btnDogCreate_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnDogCreate.Click
        'Validate Data in textboxes
        If txtDogBreed.Text <> String.Empty Then
            If txtDogWeight.Text <> String.Empty Then
                If cboDogColor.Text <> String.Empty Then
                    'Declare Objects and Variables 
                    Dim objDog As New Dog(txtDogBreed.Text)

                    'Assign Dog Properties
                    objDog.Breed = txtDogBreed.Text
                    objDog.Weight = txtDogWeight.Text
                    objDog.Color = cboDogColor.Text

                    'Process and Display Output
                    lbxDog.Text = objDog.Breed
                    lbxDog.Text = objDog.Dog_Description


                    'Add new Dog Object to list of Dogs
                    lstDog.Add(objDog)

                End If
            Else MessageBox.Show("Breed cannot be blank.")
            End If
        Else MessageBox.Show("Weight cannot be blank.")
        End If
    End Sub

    Private Sub btnPhilosopherCreate_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnPhilosopherCreate.Click
        'Validate Data in textboxes
        If txtName.Text <> String.Empty Then
            If txtQuote.Text <> String.Empty Then
                If txtDate.Text <> String.Empty Then
                    'Declare Objects and Variables 
                    Dim objPhilosopher As New Philosopher(txtName.Text)

                    'Assign Philosopher Properties
                    objPhilosopher.Name = txtName.Text
                    objPhilosopher.Quote = txtQuote.Text
                    objPhilosopher.UserDate = txtDate.Text

                    'Process and Display Output
                    lbxPhilosopher.Text = objPhilosopher.Name
                    lbxPhilosopher.Text = objPhilosopher.Philosopher_Quote


                    'Add new Philosopher Object to list of Cars
                    lstPhilosopher.Add(objPhilosopher)

                Else Messagebox.Show("Date cannot be blank.")
                End If
            Else MessageBox.Show("Name cannot be blank.")
            End If
        Else MessageBox.Show("Quote cannot be blank.")
        End If
    End Sub


    Private Sub lbxCar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxCar.SelectedIndexChanged
        Dim objSelectedCar As Car = CType(lbxCar.SelectedItem, Car)
        MessageBox.Show(objSelectedCar.Car_Name)
    End Sub

    Private Sub lbxDog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxDog.SelectedIndexChanged
        Dim objSelectedDog As Dog = CType(lbxDog.SelectedItem, Dog)
        MessageBox.Show(objSelectedDog.Dog_Description)
    End Sub

    Private Sub lbxPhilosopher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxPhilosopher.SelectedIndexChanged
        Dim objSelectedPhilosopher As Philosopher = CType(lbxPhilosopher.SelectedItem, Philosopher)
        MessageBox.Show(objSelectedPhilosopher.Philosopher_Quote)
    End Sub
End Class
