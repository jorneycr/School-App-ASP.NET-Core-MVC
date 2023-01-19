use SchoolManagementDb

CREATE TABLE Classes(
    Id int PRIMARY key IDENTITY,
    LecturerId int FOREIGN KEY REFERENCES Lecturers(Id),
    CourseId int FOREIGN KEY REFERENCES Courses(Id),
    [Time] TIME
)

CREATE TABLE Enrollments(
    Id int PRIMARY key IDENTITY,
    StudentId int FOREIGN KEY REFERENCES Students(Id),
    ClassId int FOREIGN KEY REFERENCES Classes(Id),
    Grade NVARCHAR(2)
)