# Battery Charge Planner

A simple full-stack energy optimization tool built with **C# ASP.NET Core** and **JavaScript**.

The application gives a recommendation based on the current battery level and electricity price. It can suggest whether the user should charge the battery, use battery power, save battery, or do nothing.

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

The frontend sends a request to the C# backend with:

```json
{
  "batteryLevel": 40,
  "electricityPrice": 0.8
}
```
