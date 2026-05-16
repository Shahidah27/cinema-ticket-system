Public Class Form7

    Public receiptItems As New List(Of String) 'array of list to store receipt Items
    Public totalAll As Double

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPopcorn.Items.Clear()
        cboPopcorn.Items.Add("Small")
        cboPopcorn.Items.Add("Medium")
        cboPopcorn.Items.Add("Large")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim flavour As String
        Dim qtyPopcorn, qtyFries, qtyNuggets, qtyDorritos, qtyBurrito, qtyWings, qtyBurger, qtyLemonTea, qtySprite, qtyWater As Integer

        qtyPopcorn = Val(txtPopcornQty.Text)
        qtyFries = Val(txtFriesQty.Text)
        qtyNuggets = Val(txtNuggetQty.Text)
        qtyDorritos = Val(txtDorritosQty.Text)
        qtyBurrito = Val(txtBurritoQty.Text)
        qtyWings = Val(txtWingsQty.Text)
        qtyBurger = Val(txtBurgerQty.Text)
        qtyLemonTea = Val(txtLemonTeaQty.Text)
        qtySprite = Val(txtSpriteQty.Text)
        qtyWater = Val(txtWaterQty.Text)

        Dim pricePopcorn As Double = 0.00
        Dim priceFood As Double = 0.00
        Dim priceBeverage As Double = 0.00
        Dim priceCombo As Double = 0.00
        Dim total As Double = 0.00

        'Popcorn selection
        If chkPopcorn.Checked Then

            If cboPopcorn.SelectedIndex = -1 Then
                MessageBox.Show("Please choose the size")
                Exit Sub
            Else
                If radCaramel.Checked Then
                    flavour = "Caramel"
                ElseIf radSalted.Checked Then
                    flavour = "Salted"
                Else
                    MessageBox.Show("Please choose popcorn flavour!")
                    Exit Sub
                End If

                If txtPopcornQty.Text = "" Then
                    MessageBox.Show("Please enter popcorn quantity!")
                    txtPopcornQty.Focus()
                    Exit Sub
                End If

                If cboPopcorn.SelectedItem.ToString() = "Small" Then
                    lstFood.Items.Add("Popcorn " & flavour & " (Small) " & qtyPopcorn & "x")
                    receiptItems.Add("Popcorn " & flavour & " (Small) " & qtyPopcorn & "x")
                    pricePopcorn = 9.9
                ElseIf cboPopcorn.SelectedItem.ToString() = "Medium" Then
                    lstFood.Items.Add("Popcorn " & flavour & " (Medium) " & qtyPopcorn & "x")
                    receiptItems.Add("Popcorn " & flavour & " (Medium) " & qtyPopcorn & "x")
                    pricePopcorn = 11.9
                ElseIf cboPopcorn.SelectedItem.ToString() = "Large" Then
                    lstFood.Items.Add("Popcorn " & flavour & " (Large) " & qtyPopcorn & "x")
                    receiptItems.Add("Popcorn " & flavour & " (Large) " & qtyPopcorn & "x")
                    pricePopcorn = 12.9
                End If
            End If
        End If

        'Food Selection
        If chkFries.Checked Then
            If txtFriesQty.Text = "" Then
                MessageBox.Show("Please enter french fries quantity!")
                txtFriesQty.Focus()
                Exit Sub
            End If

            lstFood.Items.Add("French Fries " & qtyFries & "x")
            receiptItems.Add("French Fries " & qtyFries & "x")
            priceFood += 6.0 * qtyFries
        End If

        If chkNuggets.Checked Then
            If txtNuggetQty.Text = "" Then
                MessageBox.Show("Please enter nuggets quantity!")
                txtNuggetQty.Focus()
                Exit Sub
            End If

            lstFood.Items.Add("Nuggets " & qtyNuggets & "x")
            receiptItems.Add("Nuggets " & qtyNuggets & "x")
            priceFood += 7.5 * qtyNuggets
        End If

        If chkDorritos.Checked Then
            If txtDorritosQty.Text = "" Then
                MessageBox.Show("Please enter dorritos quantity!")
                txtDorritosQty.Focus()
                Exit Sub
            End If

            lstFood.Items.Add("Dorritos " & qtyDorritos & "x")
            receiptItems.Add("Dorritos " & qtyDorritos & "x")
            priceFood += 5.5 * qtyDorritos
        End If

        If chkBurrito.Checked Then
            If txtBurritoQty.Text = "" Then
                MessageBox.Show("Please enter burrito quantity!")
                txtBurritoQty.Focus()
                Exit Sub
            End If

            lstFood.Items.Add("Burrito " & qtyBurrito & "x")
            receiptItems.Add("Burrito " & qtyBurrito & "x")
            priceFood += 8.5 * qtyBurrito
        End If

        If chkWings.Checked Then
            If txtWingsQty.Text = "" Then
                MessageBox.Show("Please enter wings quantity!")
                txtWingsQty.Focus()
                Exit Sub
            End If

            lstFood.Items.Add("Chicken Wings " & qtyWings & "x")
            receiptItems.Add("Chicken Wings " & qtyWings & "x")
            priceFood += 9.5 * qtyWings
        End If

        If chkBurger.Checked Then
            If txtBurgerQty.Text = "" Then
                MessageBox.Show("Please enter burger quantity!")
                txtBurgerQty.Focus()
                Exit Sub
            End If

            lstFood.Items.Add("Burger " & qtyBurger & "x")
            receiptItems.Add("Burger " & qtyBurger & "x")
            priceFood += 8.0 * qtyBurger
        End If

        'Beverage selection
        If chkLemonTea.Checked Then
            If txtLemonTeaQty.Text = "" Then
                MessageBox.Show("Please enter lemon tea quantity!")
                txtLemonTeaQty.Focus()
                Exit Sub
            End If

            lstFood.Items.Add("Lemon Tea " & qtyLemonTea & "x")
            receiptItems.Add("Lemon Tea " & qtyLemonTea & "x")
            priceBeverage += 4.5 * qtyLemonTea
        End If

        If chkSprite.Checked Then
            If txtSpriteQty.Text = "" Then
                MessageBox.Show("Please enter sprite quantity!")
                txtSpriteQty.Focus()
                Exit Sub
            End If

            lstFood.Items.Add("Sprite " & qtySprite & "x")
            receiptItems.Add("Sprite " & qtySprite & "x")
            priceBeverage += 4.5 * qtySprite
        End If

        If chkWater.Checked Then
            If txtWaterQty.Text = "" Then
                MessageBox.Show("Please enter mineral water quantity!")
                txtWaterQty.Focus()
                Exit Sub
            End If

            lstFood.Items.Add("Mineral Water " & qtyWater & "x")
            receiptItems.Add("Mineral Water " & qtyWater & "x")
            priceBeverage += 3.0 * qtyWater
        End If

        'Combo set selection
        If chkSetA.Checked Then
            lstFood.Items.Add("Combo Set A")
            receiptItems.Add("Combo Set A")
            priceCombo += 12.9
        End If

        If chkSetB.Checked Then
            lstFood.Items.Add("Combo Set B")
            receiptItems.Add("Combo Set B")
            priceCombo += 21.9
        End If

        If chkSetC.Checked Then
            lstFood.Items.Add("Combo Set C")
            receiptItems.Add("Combo Set C")
            priceCombo += 29.9
        End If

        If chkSetD.Checked Then
            lstFood.Items.Add("Combo Set D")
            receiptItems.Add("Combo Set D")
            priceCombo += 40.9
        End If

        total = (pricePopcorn * qtyPopcorn) + priceFood + priceBeverage + priceCombo
        totalAll += total
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstFood.Items.Clear()
        receiptItems.Clear()
        totalAll = 0.00

        btnAdd.Enabled = True

        chkPopcorn.Checked = False
        chkFries.Checked = False
        chkNuggets.Checked = False
        chkDorritos.Checked = False
        chkBurrito.Checked = False
        chkWings.Checked = False
        chkBurger.Checked = False
        chkLemonTea.Checked = False
        chkSprite.Checked = False
        chkWater.Checked = False
        chkSetA.Checked = False
        chkSetB.Checked = False
        chkSetC.Checked = False
        chkSetD.Checked = False

        cboPopcorn.SelectedIndex = -1
        radCaramel.Checked = False
        radSalted.Checked = False

        txtPopcornQty.Text = ""
        txtFriesQty.Text = ""
        txtNuggetQty.Text = ""
        txtDorritosQty.Text = ""
        txtBurritoQty.Text = ""
        txtWingsQty.Text = ""
        txtBurgerQty.Text = ""
        txtLemonTeaQty.Text = ""
        txtSpriteQty.Text = ""
        txtWaterQty.Text = ""
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        lstFood.Items.Add("=================================================")
        lstFood.Items.Add("Total: RM " & totalAll.ToString("N2"))
        lstFood.Items.Add("=================================================")
        btnAdd.Enabled = False
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        Label3.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        Label3.Font = FontDialog1.Font
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class