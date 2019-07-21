﻿using Common;

namespace SaveFileLogNAS.Globalization
{
   public class GuiFrench : IGui
   {
      // Initial values
      public string InitialTextOnLogContent { get; } = "Copier les logs ici ...";
      public string InitialTextOnInfoName { get; } = "Écrire les informations de nom ici ...";

      // Controls
      public string AppTitle { get; } = "Save File Log NAS";
      public string CheckBoxIsError { get; } = "Erreur ?";
      public string ButtonSave { get; } = "Enregistrer";
      public string ButtonHelp { get; } = "?";
      public string ButtonClear { get; } = "X";

      // Tooltips
      public string AppToolTip { get; } = "Save File Log NAS";
      public string TextBoxLogContentToolTip { get; } = "Copier les logs ici ...";
      public string TextBoxInfoNameToolTip { get; } = "Écrire les informations de nom ici ...";
      public string CheckBoxIsErrorToolTip { get; } = "Erreur ?";
      public string ButtonSaveToolTip { get; } = "Enregistrer";
      public string ButtonHelpToolTip { get; } = "Aide ?";
      public string ButtonClearToolTip { get; } = "RAZ";

      // Saving
      public string MessageBoxLogSavedOK { get; } = "Sauvegarde effectuée. Fichier de log :";

      // Help message box
      public string MessageBoxHelpCaption { get; } = "Aide";
      public string MessageBoxHelpHelp { get; } = $"HELP !{CommonText.NewLine}{CommonText.NewLine}"
                                                + $"Copier les fichiers de log d'Open Media Vault "
                                                + $"dans le champ de texte. Puis cliquer sur \"Enregistrer\" pour enregistrer"
                                                + $"le fichier dans le dossier de log. Si celui-ci est inexistant, "
                                                + $"le fichier sera enregistré sur le bureau.{CommonText.NewLine}"
                                                + $"Ajouter un complément de nom dans le champ d'informations.";
      public string MessageBoxHelpAbout { get; } = "À PROPOS :";
      public string MessageBoxHelpBuild { get; } = "Compilation :   ";
      public string MessageBoxHelpVersion { get; } = "Version :   ";

      // Field error messages
      public string ErrorOnFieldLogContent { get; } = "Copier le log dans le champ.";
      public string ErrorOnFieldInfoName { get; } = "Écrire les informations de nom.";

      // Error on folder path
      public string ErrorCreatingFolder { get; } = "Erreur lors de la création du dossier de sauvegarde.";
   }
}