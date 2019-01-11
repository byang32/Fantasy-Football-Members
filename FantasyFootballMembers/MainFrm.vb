Option Strict On
Option Explicit On
Imports System.ComponentModel
Imports System.Data.SqlClient
'Fatasy Football League

'Bee Yang
'Date created 10/1/2016
'Last date modified 10/19/2016
'This application is designed to add teams into the database 
'and display team statistics.


Public Class MainFrm

    Dim newMember As New FantasyFootballMembers()
    Dim FantasyFootballMembers As New BindingList(Of FantasyFootballMembers)
    Dim lastID As Integer

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        newMember = New FantasyFootballMembers

        'Assignment Statments
        newMember.fName = txtFname.Text
        newMember.lName = txtLname.Text
        newMember.teamName = txtTname.Text

        'Shows message if no user input is entered
        If newMember.fName = "" Then
            MessageBox.Show("Enter a first name")
        ElseIf newMember.lName = "" Then
            MessageBox.Show("Enter a last name")
        ElseIf newMember.teamName = "" Then
            MessageBox.Show("Enter a Team Name")
        End If

        FantasyFootballMembers.Add(newMember) 'Adds new  members into listbox

        Dim dbConnection As SqlConnection = connectToDb() 'get connection to database

        'inserting into database
        Dim sqlString As String = "INSERT INTO Stats (FirstName, LastName, TeamName) VALUES(@firstname, @lastname, @teamname)"

        Dim com As New SqlCommand(sqlString, dbConnection) 'sql command and place holders

        com.Parameters.Add("@firstname", SqlDbType.VarChar).Value = newMember.fName
        com.Parameters.Add("@lastname", SqlDbType.VarChar).Value = newMember.lName
        com.Parameters.Add("@teamname", SqlDbType.Text).Value = newMember.teamName
        com.Parameters.Add("@championshipswon", SqlDbType.Int).Value = newMember.championship
        com.Parameters.Add("@memberid", SqlDbType.Int).Value = newMember.memberID

        Try
            Dim result = com.ExecuteNonQuery()
            MessageBox.Show(result.ToString)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        clearTextBox() 'clear user input text box

    End Sub

    'clear Text box after values are entered.
    Private Sub clearTextBox()
        txtFname.Text = String.Empty
        txtLname.Text = String.Empty
        txtTname.Text = String.Empty
    End Sub

    'Lable displays member information submitted
    Private Sub displayTeams()

        lblDisplayFName.Text = newMember.fName
        lblDisplayLName.Text = newMember.lName
        lblDisplayTeamName.Text = newMember.teamName
        lblDisplayWins.Text = newMember.championship.ToString
        lblDisplayMemID.Text = newMember.memberID.ToString
    End Sub

    'Add member into list box and displays database
    Private Sub lstboxMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxMembers.SelectedIndexChanged
        newMember = CType(lstboxMembers.SelectedItem, FantasyFootballMembers)
        displayTeams()
    End Sub

    'Display the user team name to the list box.
    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstboxMembers.DataSource = FantasyFootballMembers
        lstboxMembers.DisplayMember = "teamName"

        Dim dbconnection As SqlConnection = connectToDb()

        Dim sqlString As String = "SELECT * FROM Stats"
        Dim selectCom As New SqlCommand(sqlString, dbconnection)

        Try
            Dim reader As SqlDataReader = selectCom.ExecuteReader()

            If reader.HasRows Then
                While reader.Read
                    teamStatistics(reader)
                End While
            End If

            reader.Close()
        Catch
        End Try

        dbConnection.Close()
        dbConnection.Dispose()

    End Sub

    'Function to connect and retrieve database connection
    Private Function connectToDb() As SqlConnection

        Dim connectionString As String = "Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\beeya\Desktop\FantasyFootballMembers\FantasyFootballMembers\Members.mdf;"
        Dim dbConnection As New SqlConnection(connectionString)
        dbConnection.Open()
        Return dbConnection

    End Function

    Private Sub teamStatistics(reader As SqlDataReader)
        Dim dbStats As New FantasyFootballMembers()

        dbStats.fName = reader.Item("FirstName").ToString   'reading from the database
        dbStats.lName = reader.Item("LastName").ToString
        dbStats.memberID = CInt(reader.Item("MemberID").ToString)
        dbStats.teamName = reader.Item("TeamName").ToString
        dbStats.championship = CInt(reader.Item("ChampionshipsWon").ToString)

        FantasyFootballMembers.Add(dbStats)
    End Sub

End Class
