function capture() {
    html2canvas(document.body).then(canvas => {

        let a = document.createElement("a");
        a.download = "ReportImg.png";
        a.href = canvas.toDataURL("image/png");
        a.click(); // MAY NOT ALWAYS WORK!
    });
}