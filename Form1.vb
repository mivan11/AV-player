Public Class AVP
    Private Playlist As WMPLib.IWMPPlaylist
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tekst.Text = "Dobrodošli!"
        Dim folderPath As String
        WMP.settings.volume = 50
        'AxWindowsMediaPlayer1.uiMode = "none"
        WMP.settings.setMode("loop", True)
        Playlist = WMP.newPlaylist("MyPlayList", "")
        WMP.currentPlaylist = Playlist
        ' AxWindowsMediaPlayer1.Ctlcontrols.play()
        ' WMP.Ctlcontrols.play()
    End Sub
    Private Sub Prvi_Click(sender As Object, e As EventArgs) Handles Prvi.Click
        'FolderBrowserDialog1.ShowDialog()
        WMP.URL = ""
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            'Prvi.Enabled = False
            'Playlist.clear()
            For Each video As String In IO.Directory.GetFiles(FolderBrowserDialog1.SelectedPath, "*.mp3")
                Playlist.appendItem(WMP.newMedia(video.LastIndexOf("\") + 1))
                '  If (Playlist.Equals(Lista.Items)) Then
                ' If (Playlist.Exists(Lista.Items)) Then
                ' Else
                '    Me.Lista.Items.Add(IO.Path.GetFileNameWithoutExtension(video) + (System.IO.Path.GetFullPath(video)))
                Lista.Items.Add(IO.Path.GetFileNameWithoutExtension(video))
                Lista2.Items.Add(video)
                '            Lista.Items.Add(video.Substring(video.LastIndexOf("\") + 1))
                'End If
            Next
            WMP.Ctlcontrols.play()
        End If
        'WMP.Ctlcontrols.play()
    End Sub
    Private Sub Drugi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Drugi.Click
        Odaberi.ShowDialog()
        Odaberi.Multiselect = True
        Dim NazivPjesme As String = ""
        Odaberi.Filter = "(mp3,wav,mp4,mov,wmv,mpg,avi,3gp,flv)|*.mp3;*.wav;*.mp4;*.3gp;*.avi;*.mov;*.flv;*.wmv;*.mpg|all files|*.*"
        Dim podjela As Integer
        Dim tocka As Integer
        If DialogResult.OK Then
            WMP.URL = Odaberi.FileName
            For Each track As String In Odaberi.FileNames
                'NazivPjesme = track
                ' If (Lista.Items.Add(track) Then
                Lista.Items.Add(IO.Path.GetFileNameWithoutExtension(track))
                Lista2.Items.Add(track)
                'Lista2.Items.Add(WMP.URL)
            Next
        End If
        Tekst.Text = "Uživajte..."
    End Sub '
    Private Sub Lista_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lista.SelectedIndexChanged
        Lista2.SelectedIndex = Lista.SelectedIndex
    End Sub
    Private Sub Lista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lista.DoubleClick
        WMP.URL = Lista2.SelectedItem
    End Sub
    'Private Sub Izbrisi_Click() Handles Izbriši.Click
    '    Lista.Items.Remove(Lista.SelectedItem)
    '    Lista2.Items.Remove(Lista2.SelectedItem)
    '    Lista.Refresh()
    '    Lista2.Refresh()
    'End Sub
    ' Private Sub Izbrisi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Izbrisi.Click
    '    Lista2.Items.RemoveAt(Lista2.SelectedItem)
    '   Lista.Items.RemoveAt(Lista.SelectedItem)
    'Lista2.SelectedItem.Clear()
    'End Sub
    Private Sub IzbrisiSve_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles IzbrisiSve.Click
        Lista.Items.Clear()
        Lista2.Items.Clear()
        WMP.URL = ""
    End Sub
    'Private Sub IzbrisiSve_Click() Handles IzbrisiSve.Click
    '    Lista.Items.Clear()
    '    Lista2.Items.Clear()
    'End Sub
End Class

















