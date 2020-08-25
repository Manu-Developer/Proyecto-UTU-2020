Public Class GestionReservas
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub GestionReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add("1", "Manuel", "Muñiz", "02/01/2000", "095202365", "Calle 4 de Julio", "US$ 2000", "Debito", "01/09/2020", "03/09/2020", "2", "John", "03/05/2015", "Ninguna", "Ninguna", "Ninguno", "20 Kg", "Bulldog", "Premium", "Entrega por cliente", "Entre 11 AM y 12 AM", "Retiro por cliente", "Entre 11 AM y 12 AM")
        DataGridView1.Rows.Add("2", "Agustin", "Robaina", "03/01/2000", "093246566", "Calle Hotelero", "US$ 3000", "Contado", "01/09/2020", "04/09/2020", "3", "Pepe", "04/05/2015", "Ninguna", "Ninguna", "Ninguno", "21 Kg", "Poodle", "Premium", "Entrega por camioneta", "Entre 12 AM y 13 AM", "Retiro por camioneta", "Entre 12 AM y 13 AM")
        DataGridView1.Rows.Add("3", "Fabrizio", "Bravo", "04/01/2000", "093547687", "Julio y Herrera", "US$ 1500", "Debito", "01/09/2020", "05/09/2020", "4", "Coscu", "05/05/2015", "Ninguna", "Ninguna", "Ninguno", "22 Kg", "Beagle", "Premium", "Entrega por cliente", "Entre 13 AM y 14 AM", "Retiro por cliente", "Entre 13 AM y 14 AM")
        DataGridView1.Rows.Add("4", "Ignacio", "De Mello", "05/01/2000", "097823546", "Calle Sauce", "US$ 150", "Contado", "01/09/2020", "06/09/2020", "5", "Pimpeano", "06/05/2015", "Ninguna", "Ninguna", "Ninguno", "23 Kg", "Dachshund", "Premium", "Entrega por cliente", "Entre 15 PM y 16 PM", "Retiro por camioneta", "Entre 15 PM y 16 PM")
        DataGridView1.Rows.Add("5", "Fabrizio", "Bravo", "06/01/2000", "093547687", "Julio y Herrera", "US$ 1500", "Debito", "01/09/2020", "07/09/2020", "6", "Fran", "07/05/2015", "Ninguna", "Ninguna", "Ninguno", "24 Kg", "Husky", "Premium", "Entrega por camioneta", "Entre 14 PM y 15 PM", "Retiro por cliente", "Entre 14 PM y 15 PM")
        DataGridView1.Rows.Add("6", "Manuel", "Muñiz", "07/01/2000", "095202365", "Calle 4 de Julio", "US$ 2000", "Contado", "01/09/2020", "08/09/2020", "7", "Joaco", "08/05/2015", "Ninguna", "Ninguna", "Ninguno", "25 Kg", "Doberman", "Premium", "Entrega por cliente", "Entre 17 PM y 18 PM", "Retiro por camioneta", "Entre 17 PM y 18 PM")
        DataGridView1.Rows.Add("7", "Gonzalo", "Perez", "08/01/2000", "094656804", "Julio y Herrera", "US$ 1500", "Debito", "01/09/2020", "09/09/2020", "8", "Romina", "09/05/2015", "Ninguna", "Ninguna", "Ninguno", "26 Kg", "Rottweiler", "Premium", "Entrega por cliente", "Entre 18 PM y 19 PM", "Retiro por cliente", "Entre 17 PM y 18 PM")
        DataGridView1.Rows.Add("8", "Ignacio", "De Mello", "09/01/2000", "097823546", "Calle Sauce", "US$ 150", "Contado", "01/09/2020", "10/09/2020", "9", "Brian", "10/05/2015", "Ninguna", "Ninguna", "Ninguno", "25 Kg", "Bichón maltés", "Premium", "Entrega por camioneta", "Entre 12 AM y 13 AM", "Retiro por camioneta", "Entre 12 AM y 13 AM")
        DataGridView1.Rows.Add("9", "Fabrizio", "Bravo", "10/01/2000", "093547687", "Julio y Herrera", "US$ 1500", "Debito", "01/09/2020", "11/09/2020", "10", "Rodolfo", "11/05/2015", "Ninguna", "Ninguna", "Ninguno", "28 Kg", "Terranova", "Premium", "Entrega por cliente", "Entre 11 AM y 12 AM", "Retiro por cliente", "Entre 11 AM y 12 AM")
        DataGridView1.Rows.Add("10", "Gonzalo", "Perez", "11/01/2000", "094656804", "Julio y Herrera", "US$ 1500", "Contado", "01/09/2020", "12/09/2020", "11", "Rubius", "11/05/2015", "Ninguna", "Ninguna", "Ninguno", "29 Kg", "Dálmata", "Premium", "Entrega por camioneta", "Entre 15 PM y 16 PM", "Retiro por cliente", "Entre 15 PM y 16 PM")
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Pagina1.ShowDialog()
    End Sub
End Class