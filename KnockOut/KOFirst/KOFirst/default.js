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

    //function Sample(name, marks) {
    //    var self = this;

    //    self.name = ko.observable(name);
    //    self.marks = ko.observable(marks);
    //    self.grade = ko.computed(function () {
    //        if (self.marks() > 75) {
    //            return "A";
    //        }
    //        else if (self.marks() > 40) {
    //            return "B";
    //        }
    //        else {
    //            return "C";
    //        }
    //    });
    //};

    //function SampleViewModel() {
    //    var self = this;

    //    self.list = ko.observableArray([
    //        new Sample("Test", 100),
    //        new Sample("ABC", 50),
    //        new Sample("XYZ", 20)
    //    ]);

    //    self.setEditMode = ko.observable(false);
    //    self.setSample = ko.observable(new Sample("",0));

    //    self.removeSample = function (sample) {
    //        self.list.remove(sample);
    //    };

    //    self.addSample = function () {
    //        var name = $('#name').val();
    //        var marks = $('#marks').val();

    //        if (name === undefined || name === "")
    //            return;

    //        if (isNaN(marks) || marks < 0 || marks > 100)
    //            return;

    //        self.list.push(new Sample(name, marks));
    //    };

    //    self.editSample = function (sample) {
    //        self.setSample(new Sample(sample.name(), sample.marks()));
    //        self.setEditMode(true);
    //    };

    //    self.saveSample = function () {
    //        for (var i = 0 ; i < self.list().length ; i++) {
    //            if (self.list()[i].name() == self.setSample().name()) {
    //                self.list()[i].marks(self.setSample().marks());
    //                console.log("Value updated! " + self.setSample().marks() + " " + self.list()[i].marks());
    //                self.setEditMode(false);
    //                break;
    //            }
    //        }
    //    };
    //}

    function Student(rollno, name, marks) {
        var self = this;

        self.rollno = ko.observable(rollno);
        self.name = ko.observable(name);
        self.marks = ko.observable(marks);
    };

    function StudentViewModel() {
        var self = this;

        self.list = ko.observableArray([]);
        self.setEditMode = ko.observable(false);
        self.setStudent = ko.observable(new Student(0,"", 0));

        self.clearList = function () {
            self.list([]);
        }

        self.getStudents = function () {
            $.get("http://localhost:52255/api/students",
                null,
                function (students) {
                    for (var i = 0 ; i < students.length ; i++) {
                        self.list.push(new Student(students[i].RollNo, students[i].Name, students[i].Marks));
                    }
                }, "JSON");
        };

        self.addStudent = function () {
            var rollno = $('#rollno').val();
            var name = $('#name').val();
            var marks = $('#marks').val();

            if (rollno === undefined || isNaN(rollno))
                return;

            if (name === undefined || name === "")
                return;

            if (isNaN(marks) || marks < 0 || marks > 100)
                return;

            $.ajax({
                url: "http://localhost:52255/api/students/",
                type: 'POST',
                data: { RollNo: $("#rollno").val(), Name: $("#name").val(), Marks: $("#marks").val() },
                success: function (result) {
                    alert("Success");
                    self.clearList();
                    self.getStudents();
                },
                error: function (result) {
                    console.log(result);
                    alert(result);
                }
            });            
        };

        self.editStudent = function (student) {
            self.setStudent(new Student(student.rollno(), student.name(), student.marks()));
            self.setEditMode(true);
        };

        self.removeStudent = function (student) {
            $.ajax({
                url: "http://localhost:52255/api/students/" + student.rollno(),
                type: 'DELETE',
                success: function (data) {
                    alert(data);
                    self.clearList();
                    self.getStudents();
                },
                error: function (data) {
                    alert(data);
                }
            });
        };

        self.saveStudent = function () {
            $.ajax({
                url: "http://localhost:52255/api/students/" + self.setStudent().rollno(),
                type: 'PUT',
                data: { Name: self.setStudent().name(), Marks: self.setStudent().marks() },
                success: function (result) {
                    alert(result);
                    self.setEditMode(false);
                    self.clearList();
                    self.getStudents();
                },
                error: function (result) {
                    console.log(result);
                    alert(result);
                }
            });
            
        };
    }

    var vm = new StudentViewModel()
    vm.getStudents();
    ko.applyBindings(vm);


});