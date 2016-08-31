
/// <reference path="../angular.js" />

/// <reference path="Module.js" />



app.controller('EmployeeController', function ($scope, EmployeeService) {
    $scope.IsNewRecord = 1;
    Loaddate();

    function Loaddate() {
        debugger;
      
        var EmpGet = EmployeeService.getEmployees();

        EmpGet.then(function (pl) {
            debugger;
            $scope.Employees = pl.data
        },
              function (errorPl) {
                  $log.error('failure loading Employee', errorPl);
              });
    }

    $scope.save = function () {
        var Employee = {
            id: $scope.id,
            Name: $scope.Name,
            Address: $scope.Address,
            Salary: $scope.Salary
        };
        //If the flag is 1 the it si new record
        if ($scope.IsNewRecord === 1) {
            debugger;
            var EmployeePost = EmployeeService.post(Employee);
            EmployeePost.then(function (x) {
                debugger;
                $scope.id = x.data.id;
                Loaddate();
            }, function (err) {
                console.log("Err" + err);
            });
        } else { //Else Edit the record
            debugger;
            var EmployeePut = EmployeeService.put($scope.id, Employee);
            EmployeePut.then(function (pl) {
                $scope.Message = "Updated Successfuly";
                Loaddate();
            }, function (err) {
                console.log("Err" + err);
            });
        }



    };
});