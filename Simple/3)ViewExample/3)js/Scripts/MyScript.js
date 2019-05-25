window.onunload = askConfirm;
function askConfirm() {
    return "You have unsaved changes.";
}