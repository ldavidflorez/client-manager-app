-- Drop table if exists
DROP TABLE IF EXISTS clients;

-- Create clients table
CREATE TABLE clients (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100),
    lastname VARCHAR(100),
    account_number VARCHAR(50) UNIQUE,
    balance NUMERIC(15, 2),
    date_of_birth DATE,
    address TEXT,
    phone VARCHAR(20),
    email VARCHAR(100),
    client_type VARCHAR(20) CHECK (client_type IN ('individual', 'corporate')),
    marital_status VARCHAR(20),
    identification_number VARCHAR(50) UNIQUE,
    profession VARCHAR(100),
    gender VARCHAR(10) CHECK (gender IN ('Male', 'Female', 'Other')),
    nationality VARCHAR(50)
);

-- Insert dummy data into the clients table
INSERT INTO clients (name, lastname, account_number, balance, date_of_birth, address, phone, email, client_type, marital_status, identification_number, profession, gender, nationality)
VALUES
('John', 'Doe', 'ACC1234567', 1500.50, '1980-01-15', '123 Elm St, Springfield, IL', '555-1234', 'john.doe@example.com', 'individual', 'single', 'ID123456789', 'Software Engineer', 'Male', 'American'),
('Jane', 'Smith', 'ACC2345678', 2300.75, '1992-05-30', '456 Oak St, Metropolis, NY', '555-5678', 'jane.smith@example.com', 'individual', 'married', 'ID987654321', 'Data Scientist', 'Female', 'American'),
('Acme Corp', 'N/A', 'ACC3456789', 12500.00, '2000-01-01', '789 Pine St, Gotham, CA', '555-6789', 'contact@acmecorp.com', 'corporate', 'N/A', 'ID192837465', 'N/A', 'Other', 'American'),
('Alice', 'Johnson', 'ACC4567890', 500.00, '1985-07-20', '101 Maple St, Star City, TX', '555-7890', 'alice.johnson@example.com', 'individual', 'single', 'ID564738291', 'Graphic Designer', 'Female', 'American'),
('Bob', 'Brown', 'ACC5678901', 980.25, '1978-11-11', '202 Birch St, Central City, FL', '555-8901', 'bob.brown@example.com', 'individual', 'divorced', 'ID837465920', 'Marketing Manager', 'Male', 'American');

-- Drop table if exists
DROP TABLE IF EXISTS app_users;

-- Create app_users table
CREATE TABLE app_users (
    id SERIAL PRIMARY KEY,
    username VARCHAR(100) UNIQUE NOT NULL,
    password VARCHAR(100) NOT NULL,
    role VARCHAR(20) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Insert dummy data into app_users table
INSERT INTO app_users (username, password, role, created_at)
VALUES
    ('john_doe', 'e6c3da5b206634d7f3f3586d747ffdb36b5c675757b380c6a5fe5c570c714349', 'admin', '2024-05-15 09:00:00'),
    ('jane_smith', '1ba3d16e9881959f8c9a9762854f72c6e6321cdd44358a10a4e939033117eab9', 'consultant', '2024-05-15 09:15:00'),
    ('alex_williams', '3acb59306ef6e660cf832d1d34c4fba3d88d616f0bb5c2a9e0f82d18ef6fc167', 'consultant', '2024-05-15 09:30:00');
