﻿/// <reference path="D:\Visual Studio Projects\KnockOut\KOFirst\KOFirst\scripts/knockout-3.4.2.debug.js" />

$(document).ready(function () {

    //ko.bindingHandlers.fadeVisible = {
    //    init: function (element, valueAccessor) {
    //        var shouldDisplay = valueAccessor();
    //        $(element).toggle(shouldDisplay);
    //    },
    //    update: function (element, valueAccessor) {
    //        var shouldDisplay = valueAccessor();
    //        shouldDisplay ? $(element).fadeIn() : $(element).fadeOut();
    //    }
    //};

    // Student Model
    function Student(rollno, name, marks) {
        var self = this;

        self.rollno = ko.observable(rollno);
        self.name = ko.observable(name);
        self.marks = ko.observable(marks);
    };

    // ViewModel
    function StudentViewModel() {
        var self = this;

        self.list = ko.observableArray([]);
        self.setEditMode = ko.observable(false);
        self.setStudent = ko.observable({});
        self.searchText = ko.observable("");

        self.list.subscribe(function (data) {
            if (data.length == 0) {
                $('#status').show();
            }
            else {
                $('#status').hide();
            }
        });
        
        self.searchStudents = function () {
            var value = self.searchText();
            var newList = [];
            for (var i = 0; i < self._list.length; i++) {
                if (self._list[i].Name.includes(value) || self._list[i].RollNo.toString().includes(value)) {
                    newList.push(self._list[i]);
                }
            }
            $('#btnClear').prop('disabled', false);
            self.list(newList); 
        };

        self.clearSearch = function () {
            $('#btnClear').prop('disabled', true);
            self.searchText("");
            self.list(self._list);
        };

        self.getStudents = function () {
            $.get("http://localhost:52255/api/students",
                null,
                function (students) {
                    self.list(students);
                    self._list = students;
                    console.log(students);
                },
                "JSON");
        };

        self.addStudent = function () {
            var name = $('#name').val();
            var marks = $('#marks').val();

            if (name === undefined || name === "") {
                alert('Invalid Name: ' + name);
                return;
            }

            if (isNaN(marks) || marks < 0 || marks > 100) {
                alert('Invalid Marks: ' + marks);
                return;
            }

            $.ajax({
                url: "http://localhost:52255/api/students/",
                type: 'POST',
                data: { Name: $("#name").val(), Marks: $("#marks").val() },
                success: function (result) {
                    if (result === false) {
                        alert("Duplicate Roll Number Not Allowed!");
                        console.log(result);
                    }
                    else {
                        alert(result + " added!");
                        $('#rollno')[0].value = result;
                        self.getStudents();
                    }
                },
                error: function (result) {
                    console.log(result);
                    alert(result);
                }
            });
        };

        self.editStudent = function (student) {
            self.setStudent(student);
            console.log(student);
            self.setEditMode(true);
        };

        self.removeStudent = function (student) {
            $.ajax({
                url: "http://localhost:52255/api/students/" + student.RollNo,
                type: 'DELETE',
                success: function (data) {
                    alert("Success");
                    self.getStudents();
                    self.searchText("");
                    $('#btnClear').prop('disabled', true);
                },
                error: function (data) {
                    alert(data);
                }
            });
        };

        self.resetEditMode = function () {
            self.setEditMode(false);
            self.setStudent({});
        }

        self.saveStudent = function () {
            $.ajax({
                url: "http://localhost:52255/api/students/" + self.setStudent().RollNo,
                type: 'PUT',
                data: { Name: self.setStudent().Name, Marks: self.setStudent().Marks },
                success: function (result) {
                    alert("Success");
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