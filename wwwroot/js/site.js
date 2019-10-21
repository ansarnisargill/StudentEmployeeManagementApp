function Load(){
    new HelloWeek({
        selector: '.hello-week',
        lang: 'en',
        langFolder: './dist/langs/',
        format: 'DD/MM/YYYY',
        weekShort: true,
        monthShort: false,
        multiplePick: false,
        defaultDate: null,
        todayHighlight: true,
        disablePastDays: false,
        disabledDaysOfWeek: null,
        disableDates: null,
        weekStart: 0, // week start on Sunday
        daysHighlight: null,
        daysSelected: null,
        range: false,
        rtl: false,
        locked: false,
        minDate: null,
        maxDate: null,
        nav: ['◀', '▶'],
        onLoad: updateInfo,
        onChange: updateInfo,
        onSelect: updateInfo
    });
}
function updateInfo() {
    if (this.today) {
        console.log(this.today);
    }

    if (this.lastSelectedDay) {
        var date = new Date(this.lastSelectedDay);
        fetch(`/api/Shifts/${date.toISOString()}`).then(res =>  res.json()).then(res => ShowModal(res,date));
    }
}

function ShowModal(source,date) {
    $('#exampleModalLabel').empty();
    $('#exampleModalLabel').append(`Shifts for ${date.toDateString()} `);
    let Content = ``;

    Content = Content + `<table class="table table-bordered table-dark table-hover" style = "width:100%;" > <thead><tr><th>Shift Start</th><th>Shift End</th><th>Type</th><th></th></tr></thead>`;
    for (let s of source) {
        let startDate = new Date(Date.parse(s.startingTime));
        let endDate = new Date(Date.parse(s.endingTime));
        let Type = s.isMorningShift ? "Morning" : "Evening";
        console.log(s);
        Content = Content + `<tr><td>${startDate.format('hh:MM')
            }</td > <td>${endDate.format('hh:MM')}</td><td>${Type}</td><td><button class="btn btn-outline-primary">Select </button></td></tr>`;
    }
    Content = Content + `</table >`;
    $('#modelBody').empty();
    $('#modelBody').append(Content);
    $('#exampleModal').modal();
}