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
    role INT NOT NULL, 
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP()
);

CREATE TABLE ListQuestions(
    question_id INT AUTO_INCREMENT PRIMARY KEY,
    subject_id INT NOT NULL,
    class VARCHAR(255),
    chapter VARCHAR(255),
    point FLOAT,
    question VARCHAR(255) NOT NULL,
    answer VARCHAR(255) NOT NULL,
    type_answer INT NOT NULL,
    FOREIGN KEY (subject_id)
        REFERENCES Subject(subject_id)
        ON DELETE CASCADE,
    level INT,
    description VARCHAR(255),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP()
);

CREATE TABLE ExamHistorys (
    history_id INT AUTO_INCREMENT PRIMARY KEY,
    time_limit VARCHAR(255) NOT NULL,
    subject_id INT NOT NULL,
    class VARCHAR(255),
    exam_type VARCHAR(255),
    exam_date VARCHAR(255),
    point FLOAT,
    user_id INT,
    FOREIGN KEY (user_id)
        REFERENCES Users(entity_id)
        ON DELETE CASCADE,
    FOREIGN KEY (subject_id)
        REFERENCES Subject(subject_id)
        ON DELETE CASCADE,
    description VARCHAR(255),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP()
);

CREATE TABLE ExamQuestions(
    question_id INT NOT NULL,
    history_id INT NOT NULL,
    answer_choose VARCHAR(255) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP(),
    FOREIGN KEY (question_id)
        REFERENCES ListQuestions(question_id)
        ON DELETE CASCADE,
    FOREIGN KEY (history_id)
        REFERENCES ExamHistorys(history_id)
        ON DELETE CASCADE,
    description VARCHAR(255),
    PRIMARY KEY(question_id, history_id)
);