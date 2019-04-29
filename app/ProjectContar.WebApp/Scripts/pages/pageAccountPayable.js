var pageAccountPayable = function (fieldName, fieldDueDate, fieldAmount) {

    return {
        clearFields: _clearFields
    }

    function _clearFields() {
        fieldName.val('');
        fieldDueDate.val('');
        fieldAmount.val('');
        $('label').removeClass('active');
    }
}