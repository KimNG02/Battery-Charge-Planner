# Battery Charge Planner

A simple full-stack energy optimization tool built with **C# ASP.NET Core** and **JavaScript**.

The application gives a recommendation based on the current battery level and electricity price. It can suggest whether the user should charge the battery, use battery power, save battery, or do nothing.
<img width="1507" height="759" alt="battery_charge_planner" src="https://github.com/user-attachments/assets/b11bc175-0554-4e2f-8817-99a4097cdacd" />

## Features

- Enter current battery level
- Enter electricity price
- Get a battery usage recommendation
- Basic input validation
- C# backend API
- JavaScript frontend using `fetch`
- Simple rule-based decision logic

## Tech Stack

### Backend

- C#
- ASP.NET Core Web API

### Frontend

- HTML
- CSS
- JavaScript

## How It Works

User types values in the website
↓
JavaScript sends the values to C# backend
↓
C# backend checks the values and makes a recommendation
↓
JavaScript receives the answer
↓
Website shows the result
