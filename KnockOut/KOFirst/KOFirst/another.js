$(document).ready(function () {

    viewModel1 = function () {
        var self = this;

        self.name = "viewModel 1 data";
    };

    viewModel2 = function () {
        var self = this;

        self.name = "viewModel 2 data";
    };

    // can create multiple viewModels and bind to a specific dom element
    ko.applyBindings(new viewModel1(), $('#one')[0]);
    ko.applyBindings(new viewModel2(), $('#two')[0]);

});