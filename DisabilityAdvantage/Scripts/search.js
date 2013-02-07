function SchoolViewModel(data, parent) {
    //Create self variable to reference the ViewModel object
    var self = this;

    self.Parent = parent;
    self.Name = ko.observable("");
    self.DisabilityCount = ko.observable(0);
    self.TotalCount = ko.observable(0);
    self.DisabilityName = ko.observable("");
    self.DisabilityPercentage = ko.computed(function () {
        return (self.DisabilityCount() / self.TotalCount()) * 100;
    });

    //Function to map JSON data to observable properties
    self.Map = function (theData) {
        self.Name(theData.Name);
        self.DisabilityCount(theData.DisabilityCount);
        self.TotalCount(theData.TotalCount);
        self.DisabilityName(theData.DisabilityName);
    };

    self.Map(data);
}

function SearchViewModel() {
    //Create self variable to reference the ViewModel object
    var self = this;
    var theDal = new SchoolDal();
    var divisionDal = new DivisionDal();

    self.Disabilities = ko.observableArray([]);
    self.Grades = ko.observableArray([]);
    self.SelectedDisability = ko.observable("");
    self.SelectedGrade = ko.observable("");
    self.SelectedDivision = ko.observable("");
    self.Schools = ko.observableArray([]);
    self.Divisions = ko.observableArray([]);
    self.ResultMessage = ko.observable("");

    self.FindDisabilityName = function (id) {
        var output = "";
        for (var i in self.Disabilities()) {
            var disability = self.Disabilities()[i];
            if (disability.ID == id) {
                output = disability.Name;
            }
        }
        return output;
    };

    self.Fetch = function () {
        //Fetch disabilities
        self.Disabilities = ko.observableArray([
            { ID: "AUT", Name: "Autism" },
            { ID: "DB", Name: "Deaf-blindness" },
            { ID: "DD", Name: "Developmental delay" },
            { ID: "EMN", Name: "Emotional disturbance" },
            { ID: "HI", Name: "Hearing impairment" },
            { ID: "ID", Name: "Intellectual Disability" },
            { ID: "MD", Name: "Multiple disabilities" },
            { ID: "UI", Name: "Orthopedic impairment" },
            { ID: "OHI", Name: "Other health impariment" },
            { ID: "SLD", Name: "Specific learning disability" },
            { ID: "SLI", Name: "Speech or language impairment" },
            { ID: "TBI", Name: "Traumatic brain injury" },
            { ID: "VI", Name: "Visual impairment" }
        ]);

        //Fetch grades
        self.Grades = ko.observableArray([
            { ID: "PS", Name: "PS - Preschool" },
            { ID: "KG", Name: "KG - Kindergarten" },
            { ID: "1", Name: "01 - First" },
            { ID: "2", Name: "02 - Second" },
            { ID: "3", Name: "03 - Third" },
            { ID: "4", Name: "04 - Fourth" },
            { ID: "5", Name: "05 - Fifth" },
            { ID: "6", Name: "06 - Sixth" },
            { ID: "7", Name: "07 - Seventh" },
            { ID: "8", Name: "08 - Eight" },
            { ID: "9", Name: "09 - Ninth" },
            { ID: "10", Name: "10 - Tenth" },
            { ID: "11", Name: "11 - Eleventh" },
            { ID: "12", Name: "12 - Twelfth" }
        ]);

        self.SelectedDisability(self.Disabilities()[0].ID);
        self.SelectedGrade(self.Grades()[0].ID);
    };

    self.Search = function () {
        self.ResultMessage("Searching...");
        var criteria = new Criteria();
        criteria.SelectedDisability = self.SelectedDisability();
        criteria.SelectedGrade = self.SelectedGrade();
        criteria.SelectedDivision = self.SelectedDivision();

        theDal.Fetch(criteria, self.SearchComplete);
    };

    self.SearchComplete = function (data) {
        var mappedSchools = $.map(data, function (item) { return new SchoolViewModel(item, self) });
        self.Schools(mappedSchools);

        if (self.Schools().length <= 0) {
            self.ResultMessage("No results were found that match the criteria");
        }
        else {
            self.ResultMessage("");
        }
    };

    self.FetchDivisions = function () {
        divisionDal.Fetch(self.FetchDivisionsComplete);
    };

    self.FetchDivisionsComplete = function (data) {
        self.Divisions(data);
    };

    self.Fetch();
    self.FetchDivisions();
}

function Criteria() {
    var self = this;

    self.SelectedDisability = "";
    self.SelectedGrade = "";
    self.SelectedDivision = "";
}

function SchoolDal() {
    //Create self variable to reference the Dal object
    var self = this;

    //ApiUrl is the URL for the controller actions
    self.ApiUrl = "api/schools?";

    self.Fetch = function (criteria, callback) {
        var url = self.ApiUrl + "disability=" + criteria.SelectedDisability + "&grade=" + criteria.SelectedGrade + "&division=" + criteria.SelectedDivision;
        $.getJSON(url, function (data) {
            callback(data);
        });
    };
}

function DivisionDal() {
    //Create self variable to reference the Dal object
    var self = this;

    //ApiUrl is the URL for the controller actions
    self.ApiUrl = "api/divisions/";

    self.Fetch = function (callback) {
        var url = self.ApiUrl;
        $.getJSON(url, function (data) {
            callback(data);
        });
    };
}

ko.applyBindings(new SearchViewModel());