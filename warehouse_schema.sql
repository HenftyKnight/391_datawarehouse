USE DATAWAREHOUSE;

DROP TABLE date_dimension;
DROP TABLE instructor_dimesnion;
DROP TABLE courses_dimension;
DROP TABLE coures_fact;

CREATE TABLE date_dimension(
	date_id INT PRIMARY KEY,
	year	INT,
	semester VARCHAR(10)
);

CREATE TABLE instructor_dimension(
	instructor_id INT PRIMARY KEY,
	name	VARCHAR(20),
	department VARCHAR(20),
);

CREATE TABLE courses_dimension(
	course_id INT PRIMARY KEY,
	course_name VARCHAR(20),
	course_department VARCHAR(20),
);

CREATE TABLE courses_fact(
	course_id INT,
	date_id		INT,
	instructor_id INT,
	number_of_coures INT,

	FOREIGN KEY (course_id) REFERENCES courses_dimension(course_id),
	FOREIGN KEY (date_id) REFERENCES date_dimension(date_id),
	FOREIGN KEY (instructor_id) REFERENCES instructor_dimension(instructor_id)
);