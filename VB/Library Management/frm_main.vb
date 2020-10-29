Public Class frm_main

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'start the form as maximized state
        Me.WindowState = FormWindowState.Maximized

        'add background image for form
        Me.BackgroundImage = Image.FromFile("D:\Misc\Informatics\Project Documents\VB\Wallpaper.jpg")

    End Sub

    Private Sub mnu_exit_Click(sender As Object, e As EventArgs) Handles mnu_exit.Click

        'exit from the whole application
        Application.Exit()

    End Sub

    Private Sub mnu_publisher_Click(sender As Object, e As EventArgs) Handles mnu_publisher.Click

        'hide current from and show publisher form
        Me.Hide()
        frm_publisher.Show()

    End Sub

    Private Sub mnu_category_Click(sender As Object, e As EventArgs) Handles mnu_category.Click

        'hide current from and show category form
        Me.Hide()
        frm_category.Show()

    End Sub

    Private Sub mnu_member_Click(sender As Object, e As EventArgs) Handles mnu_member.Click

        'hide current from and show member form
        Me.Hide()
        frm_member.Show()

    End Sub

    Private Sub mnu_book_Click(sender As Object, e As EventArgs) Handles mnu_book.Click

        'hide current from and show book form
        Me.Hide()
        frm_book.Show()

    End Sub

    Private Sub mnu_rental_Click(sender As Object, e As EventArgs) Handles mnu_rental.Click

        'hide current form and show transaction form
        Me.Hide()
        frm_transaction.Show()

    End Sub
End Class
