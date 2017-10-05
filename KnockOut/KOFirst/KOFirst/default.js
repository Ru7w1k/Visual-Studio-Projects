/// <reference path="D:\Visual Studio Projects\KnockOut\KOFirst\KOFirst\scripts/knockout-3.4.2.debug.js" />

$(document).ready(function () {
    
    ko.bindingHandlers.fadeVisible = {
        init: function (element, valueAccessor) {
            var shouldDisplay = valueAccessor();
            $(element).toggle(shouldDisplay);
        },
        update: function (element, valueAccessor) {
            var shouldDisplay = valueAccessor();
            shouldDisplay ? $(element).fadeIn() : $(element).fadeOut();
        }
    };

    function Sample(name, marks) {
        var self = this;

        self.name = ko.observable(name);
        self.marks = ko.observable(marks);
        self.grade = ko.computed(function () {
            if (self.marks() > 75) {
                return "A";
            }
            else if (self.marks() > 40) {
                return "B";
            }
            else {
                return "C";
            }
        });
    };

    function SampleViewModel() {
        var self = this;

        self.list = ko.observableArray([
            new Sample("Test", 100),
            new Sample("ABC", 50),
            new Sample("XYZ", 20)
        ]);

        self.setEditMode = ko.observable(false);
        self.setSample = ko.observable(new Sample("",0));

        self.removeSample = function (sample) {
            self.list.remove(sample);
        };

        self.addSample = function () {
            var name = $('#name').val();
            var marks = $('#marks').val();

            if (name === undefined || name === "")
                return;

            if (isNaN(marks) || marks < 0 || marks > 100)
                return;

            self.list.push(new Sample(name, marks));
        };

        self.editSample = function (sample) {
            console.log("inside edit sample", self.setEditMode());
            self.setSample(new Sample(sample.name(), sample.marks()));
            self.setEditMode(true);
            console.log("after setting sample", self.setEditMode());
        };

        self.saveSample = function () {
            console.log("Inside SaveSample");
            for (var i = 0 ; i < self.list().length ; i++) {
                if (self.list()[i].name() == self.setSample().name()) {
                    self.list()[i].marks(self.setSample().marks());
                    console.log("Value updated! " + self.setSample().marks() + " " + self.list()[i].marks());
                    self.setEditMode(false);
                    break;
                }
            }
        };

    }

    ko.applyBindings(new SampleViewModel());


});