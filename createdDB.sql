CREATE DATABASE hnue_exam_university;
USE hnue_exam_university;

CREATE TABLE Subject (
    subject_id INT AUTO_INCREMENT PRIMARY KEY,
    subject_name VARCHAR(255) NOT NULL,
    description VARCHAR(255)
);

CREATE TABLE Users (
    entity_id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL,
    fullname VARCHAR(255),
    gender INT,
    birthday datetime,
    phonenumber VARCHAR(255),
    address VARCHAR(255),
    total_point FLOAT,
    description VARCHAR(255),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP()
);

CREATE TABLE TestKit(
    testkit_id INT AUTO_INCREMENT PRIMARY KEY,
    subject_id INT NOT NULL,
    time_limit INT NOT NULL,
    question_id INT NOT NULL,
    description VARCHAR(255),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP()
);

CREATE TABLE ExamHistory (
    history_id INT AUTO_INCREMENT PRIMARY KEY,
    class VARCHAR(255),
    exam_type VARCHAR(255),
    exam_date VARCHAR(255),
    point FLOAT,
    description VARCHAR(255),
    testkit_id INT NOT NULL,
    user_id INT,
    FOREIGN KEY (testkit_id)
        REFERENCES TestKit(testkit_id)
        ON DELETE CASCADE,
    FOREIGN KEY (user_id)
        REFERENCES Users(entity_id)
        ON DELETE CASCADE,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP()
);

CREATE TABLE ListQuestion(
    question_id INT AUTO_INCREMENT PRIMARY KEY,
    question VARCHAR(255) NOT NULL,
    answer VARCHAR(255) NOT NULL,
    subject_id INT NOT NULL,
    FOREIGN KEY (subject_id)
        REFERENCES Subject(subject_id)
        ON DELETE CASCADE,
    level INT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP()
);