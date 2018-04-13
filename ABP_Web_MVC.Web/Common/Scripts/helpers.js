var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('ABP_Web_MVC');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);