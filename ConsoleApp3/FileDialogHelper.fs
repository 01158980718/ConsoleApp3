module FileDialogHelper

open System.Windows.Forms

let showSaveFileDialog() =
    use dialog = new SaveFileDialog(
        Filter = "JSON Files|*.json|XML Files|*.xml",
        InitialDirectory = @"D:\Users\Lenovo\ConsoleApp3"
    )
    if dialog.ShowDialog() = DialogResult.OK then 
        Some dialog.FileName 
    else 
        None

let showOpenFileDialog() =
    use dialog = new OpenFileDialog(
        Filter = "JSON Files|*.json|XML Files|*.xml",
        InitialDirectory = @"D:\Users\Lenovo\ConsoleApp3"
    )
    if dialog.ShowDialog() = DialogResult.OK then 
        Some dialog.FileName 
    else 
        None

