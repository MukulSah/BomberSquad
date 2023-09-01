function createButtonClick() {
    
    $.ajax({
        type: "POST",
        url: "/Enop/Create", // Replace with your actual controller action URL
       
        success: function (response) {
            // Handle the successful response from the server here
            console.log("POST request successful");
        },
        error: function (error) {
            // Handle any errors that occurred during the request
            console.error("Error:", error);
        }
    });
};