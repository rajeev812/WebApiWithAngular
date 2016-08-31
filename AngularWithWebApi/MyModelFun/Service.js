/// <reference path="../angular.js" />
/// <reference path="Module.js" />


app.service('EmployeeService', function ($http) {


    //Create new record
    this.post = function (Employee) {
        var request = $http({
            method: "post",
            url:"api/Employee/PostEmployeSave",
           
            data: Employee
        });
        return request;
    }
    //Get Single Records
    this.get = function (EmpNo) {
        return $http.get("/api/Employee/" + EmpNo);
    }

    //Get All Employees
    this.getEmployees = function () {
   
        var result = $http.get("/api/Employee/").success(function (data, status) {
           
        }).error(function () {
            alert("Somethisg error")
        });
        return result;
        //return $http.get("/api/Employee/");



        //$http({
        //    method: "GET",
        //    url: "/api/Employee/"
        //}).then(function mySucces(response) {
        //    debugger;
        //    $scope.Emp = response.data;
        //}, function myError(response) {
        //    debugger;
        //    $scope.EmpError = response.statusText;
        //});
    }


    //Update the Record
    this.put = function (Employee) {
        var request = $http({
            method: "post",
            url: "/api/Employee/PostEmployeeEdit/0",
            data: Employee
        });
        return request;
    }
    //Delete the Record
    this.delete = function (EmpNo) {
        var request = $http({
            method: "delete",
            url: "/api/Employee/DeleteEmployee/0/" + EmpNo
        });
        return request;
    }

});
