using DependenciesLibrary.Properties;
using System.Drawing;

namespace DependenciesLibrary
{
    public static class GetImage
    {
        public static Image Get(string Image)
        {
            switch (Image)
            {
                case "Add":
                    return Resources.PanelAdd;
                case "Clear":
                    return Resources.Clear;
                case "Delete":
                    return Resources.PanelDelete;
                case "dialogError":
                    return Resources.dialogError;
                case "dialogInformation":
                    return Resources.dialogInformation;
                case "dialogQuestion":
                    return Resources.dialogQuestion;
                case "dialogSuccess":
                    return Resources.dialogSuccess;
                case "dialogWarning":
                    return Resources.dialogWarning;
                case "PanelEdit":
                    return Resources.PanelEdit;
                case "Edit":
                    return Resources.Edit;
                case "File":
                    return Resources.File;
                case "Open":
                    return Resources.Open;
                case "Restart":
                    return Resources.dialogRestart;
                case "Save":
                    return Resources.Save;
                case "SaveAs":
                    return Resources.SaveAs;
                case "Settings":
                    return Resources.Settings;
                case "Success":
                    return Resources.dialogSuccess;
                case "Open_Folder":
                    return Resources.Open_Folder;
                default:
                    return null;
            }
        }

        public static Icon GetI(string Icone)
        {
            switch (Icone)
            {
                case "icon_programm":
                    return Resources.icon_programm;
                default:
                    return null;
            }
        }
    }
}