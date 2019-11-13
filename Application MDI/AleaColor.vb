Public Class AleaColor
    Dim random As New Random()
    Function couleur_au_hasard(couleur As String, ton As String)
        Dim couleurs(0) As Color

        Select Case ton
            Case "clair"
                Select Case couleur
                    Case "blanc"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 204, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 255, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 204, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 255, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 204, 255)

                    Case "bleu"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 204, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 255, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 204, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 204, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 255, 255)

                    Case "jaune"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 204, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 204, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 204, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 204, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 204, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 255, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 255, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 255, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 255, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 255, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 204, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 204, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 204, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 204, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 204, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 255, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 255, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 255, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 255, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 255, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 204, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 204, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 204, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 204, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 204, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 255, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 255, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 255, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 255, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 255, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 255, 51)

                    Case "orange"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 153, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 153, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 153, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 153, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 153, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 153, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 153, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 153, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 153, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 153, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 153, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 153, 51)

                    Case "turquoise"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 204, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 255, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 204, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 204, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 204, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 255, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 255, 204)

                    Case "vert"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 204, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 204, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 204, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 204, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 255, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 255, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 255, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 255, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 204, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 204, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 204, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 255, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 255, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 255, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 255, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 255, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 204, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 204, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 204, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 204, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 255, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 255, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 255, 51)

                    Case "violet"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 153, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 153, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 102, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 153, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 153, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 153, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 153, 255)

                    Case Else
                        Return Color.White
                        Exit Function
                End Select




            Case "moyen"
                Select Case couleur
                    Case "bleu"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 102, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 102, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 153, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 153, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 0, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 102, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 153, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 51, 255)

                    Case "marron"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 102, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 102, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 102, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 102, 51)

                    Case "orange"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 102, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 102, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 102, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 102, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 102, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 102, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 102, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 102, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 102, 51)

                    Case "rose"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 102, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 102, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 102, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 51, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 102, 153)

                    Case "rouge"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 0, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 51, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 51, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 51, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 51, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 51, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 51, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 51, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 51, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 51, 51)

                    Case "turquoise"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 153, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 153, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 153, 204)

                    Case "vert"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 102, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 102, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 102, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 102, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 153, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 153, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 153, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 153, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 153, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 153, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 153, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 153, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 153, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 153, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 153, 51)

                    Case "violet"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 0, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 102, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 102, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 153, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 51, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 0, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 0, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 102, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 102, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 51, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 51, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 51, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 0, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 0, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 0, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 51, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 51, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 0, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 0, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 102, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 102, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 51, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 51, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 51, 255)

                    Case Else
                        Return Color.White
                        Exit Function
                End Select



            Case "foncé"
                Select Case couleur
                    Case "bleu"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 0, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 0, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 51, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 51, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 51, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 255, 255)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 0, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 102, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 51, 204)

                    Case "marron"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 51, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 51, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 51, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 0, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 0, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 0, 51)

                    Case "noir"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 0, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 0, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 0, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 0, 0, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 0, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 0, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 0, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 0, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 51, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 51, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 51, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 51, 51)

                    Case "rouge"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 51, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 51, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 51, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 0, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 0, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 153, 0, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 0, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 0, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 204, 0, 51)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 0, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 0, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 0, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 255, 0, 51)

                    Case "vert"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 102, 0)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 102, 102)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 102, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 51, 102, 51)

                    Case "violet"
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 0, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 0, 204)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 51, 153)
                        ReDim Preserve couleurs(couleurs.Count) : couleurs(couleurs.Count - 1) = Color.FromArgb(255, 102, 51, 204)

                    Case Else
                        Return Color.White
                        Exit Function
                End Select

            Case Else
                Return Color.White
                Exit Function
        End Select


        'couleurs au choix:blanc,bleu,jaune,marron,noir,orange,rose,rouge,turquoise,vert,violet 
        'tons au choix:clair, moyen,foncé 
        If couleurs.Count > 1 Then
            Return couleurs(random.Next(1, couleurs.Count - 1))
        Else
            Return Color.White
        End If
    End Function
End Class