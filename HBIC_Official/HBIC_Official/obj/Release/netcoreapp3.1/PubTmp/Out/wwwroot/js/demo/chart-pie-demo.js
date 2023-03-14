// Set new default font family and font color to mimic Bootstrap's default styling
Chart.defaults.global.defaultFontFamily = 'Nunito', '-apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif';
Chart.defaults.global.defaultFontColor = '#858796';

const LoadDataToPieChart = pieChartDatas => {
    // Pie Chart Example
    console.log(pieChartDatas);
    const dataLabels = pieChartDatas.map(x => x.label + ' (%)');
    const dataColors = pieChartDatas.map(x => x.hexColor);
    const sumData = pieChartDatas.reduce((total, currentObject) => { return total + currentObject.accountNumber }, 0);
    console.log(sumData);
    const dataAccountPers = pieChartDatas.map(x => (x.accountNumber / sumData)*100);
    const dataHoverColors = pieChartDatas.map(x => x.hoverColor);
    console.log(dataLabels);
    var ctx = document.getElementById("myPieChart");
    const bgColor = {
        id: 'bgColor',
        beforeDraw: (chart, options) => {
            const { ctx, width, height } = chart;
            ctx.fillStyle = 'white';
            ctx.fillRect(0, 0, width, height);
            ctx.restore();
        }
    }
    var myPieChart = new Chart(ctx, {
        type: 'doughnut',
        data: {
            labels: dataLabels,
            datasets: [{
                data: dataAccountPers, //sum: 100%
                //#858796 - secondary; #1cc88a - success; #f6c23e - warning; #e74a3b - danger
                backgroundColor: dataColors,
                hoverBackgroundColor: dataHoverColors,
                hoverBorderColor: "rgba(234, 236, 244, 1)",
            }],
        },
        options: {
            maintainAspectRatio: false,
            tooltips: {
                backgroundColor: "rgb(255,255,255)",
                bodyFontColor: "#858796",
                borderColor: '#dddfeb',
                borderWidth: 1,
                xPadding: 15,
                yPadding: 15,
                displayColors: false,
                caretPadding: 10,
                
            },
            legend: {
                display: true
            },
            cutoutPercentage: 80,
        },
        plugins: [bgColor]
    });
    
}


