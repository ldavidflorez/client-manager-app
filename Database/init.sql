-- Create a user, database and assing permissions 
CREATE USER myuser WITH PASSWORD 'mypassword';
CREATE DATABASE clientsdb;
GRANT ALL PRIVILEGES ON DATABASE clientsdb TO myuser;
GRANT USAGE ON SCHEMA public TO myuser;
GRANT CREATE ON SCHEMA public TO myuser;
GRANT SELECT, INSERT, UPDATE, DELETE ON ALL TABLES IN SCHEMA public TO myuser;
ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT SELECT, INSERT, UPDATE, DELETE ON TABLES TO myuser;


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