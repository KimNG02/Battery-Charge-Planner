# Battery Charge Planner
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

1. The user types values into the website.
2. JavaScript sends the values to the C# backend.
3. The C# backend checks the values and creates a recommendation.
4. JavaScript receives the answer from the backend.
5. The website shows the result to the user.
