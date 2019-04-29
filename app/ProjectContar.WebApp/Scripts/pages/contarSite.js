var contarSite = function () {


    return {
        getSiteReadyDefaults: _getSiteReadyDefaults
    }

    function _setCurrencyFieldDefault() {
        $('.currencyField').maskMoney({ thousands: ".", decimal: ",", allowZero: true }).attr('maxlength', 14);
    }

    function _setDatePickerDefault() {
        $('.datepicker').datepicker({
            autoClose: true,
            format: 'dd/mm/yyyy',
            i18n: datepicker_ptbr
        });
    }

    function _getSiteReadyDefaults() {
        _setCurrencyFieldDefault();
        _setDatePickerDefault();

        $('.tooltipped').tooltip();
    }
}