let stages = document.getElementById("stages");
let stage = {
    bedrijfsNaam: "OpenAI Nederland",
    stageVergoeding: "€500 per maand",
    stad: "Amsterdam",
    beschrijving: "Tijdens deze stage werk je mee aan AI-projecten, leer je van professionals en bouw je mee aan de toekomst.",
    logoUrl: "https://example.com/logo-openai.png"
};


function GetStageJsonData(viewtemplate) 
{
    .then(response  => response.json())
    .then((json) => {
        console.log(json);
        for (let i = 0; i < json.length; i++) 
        {
            stages.innerHTML += CreatHtmlForStage(json[i], viewtemplate);
        }
});
}

function CreatHtmlForStage(stage, viewtemplate) {
    let html = viewtemplate
        .replace("#BedrijfsNaam#", stage.bedrijfsNaam)
        .replace("#StageVergoeding#", stage.stageVergoeding)
        .replace("#Stad#", stage.stad)
        .replace("#Beschrijving#", stage.beschrijving)
        .replace("#LogoUrl#", stage.logoUrl);
    return html;
}


async function getData() {
  const url = "https://example.org/products.json";
  try {
    const response = await fetch(StageController);
    if (!response.ok) {
      throw new Error(`Response status: ${response.status}`);
    }

    const json = await response.json();
    console.log(json);
  } catch (error) {
    console.error(error.message);
  }
}

.then(response  => response.text())
.then((text) => {
    GetStageJsonData(text);
});
