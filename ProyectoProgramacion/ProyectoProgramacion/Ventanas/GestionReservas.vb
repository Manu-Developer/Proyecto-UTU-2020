Public Class GestionReservas
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub GestionReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add("0", "Gonzalo", "Perez", "094656804", "Julio y Herrera", "US$ 1500", "Contado")
        DataGridView1.Rows.Add("1", "Manuel", "Muñiz", "095202365", "Calle 4 de Julio", "US$ 2000", "Debito")
        DataGridView1.Rows.Add("2", "Agustin", "Robaina", "093246566", "Calle Hotelero", "US$ 3000", "Contado")
        DataGridView1.Rows.Add("3", "Fabrizio", "Bravo", "093547687", "Julio y Herrera", "US$ 1500", "Debito")
        DataGridView1.Rows.Add("4", "Ignacio", "De Mello", "097823546", "Calle Sauce", "US$ 150", "Contado")
        DataGridView1.Rows.Add("5", "Fabrizio", "Bravo", "093547687", "Julio y Herrera", "US$ 1500", "Debito")
        DataGridView1.Rows.Add("6", "Manuel", "Muñiz", "095202365", "Calle 4 de Julio", "US$ 2000", "Contado")
        DataGridView1.Rows.Add("7", "Gonzalo", "Perez", "094656804", "Julio y Herrera", "US$ 1500", "Debito")
        DataGridView1.Rows.Add("8", "Ignacio", "De Mello", "097823546", "Calle Sauce", "US$ 150", "Contado")
        DataGridView1.Rows.Add("9", "Fabrizio", "Bravo", "093547687", "Julio y Herrera", "US$ 1500", "Debito")
        DataGridView1.Rows.Add("10", "Gonzalo", "Perez", "094656804", "Julio y Herrera", "US$ 1500", "Contado")
    End Sub


End Class