async function getRecommendation() {
  const batteryLevel = document.getElementById("batteryLevel").value;
  const electricityPrice = document.getElementById("electricityPrice").value;
  const resultDiv = document.getElementById("result");

  if (batteryLevel === "" || electricityPrice === "") {
    resultDiv.classList.remove("hidden");
    resultDiv.innerHTML =
      "<p>Please enter both battery level and electricity price.</p>";
    return;
  }

  const requestBody = {
    batteryLevel: Number(batteryLevel),
    electricityPrice: Number(electricityPrice),
  };

  try {
    const response = await fetch(
      "http://localhost:5249/api/battery/recommendation",
      {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(requestBody),
      },
    );

    if (!response.ok) {
      const errorMessage = await response.text();
      resultDiv.classList.remove("hidden");
      resultDiv.innerHTML = `<p>${errorMessage}</p>`;
      return;
    }

    const data = await response.json();

    resultDiv.classList.remove("hidden");
    resultDiv.innerHTML = `
            <div class="recommendation">${data.recommendation}</div>
            <p>${data.reason}</p>
            <p><strong>Battery level:</strong> ${data.batteryLevel}%</p>
            <p><strong>Electricity price:</strong> ${data.electricityPrice} kr/kWh</p>
        `;
  } catch (error) {
    resultDiv.classList.remove("hidden");
    resultDiv.innerHTML =
      "<p>Could not connect to the backend. Make sure the C# API is running.</p>";
  }
}
