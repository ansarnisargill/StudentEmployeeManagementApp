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
    console.log(source);

    Content = Content + `<table class="table table-bordered table-hover" style = "width:100%;" > <thead><tr><th>Shift Start</th><th>Shift End</th><th>Type</th><th></th></tr></thead>`;
    for (let s of source) {
        let Type = s.isMorningShift ? "Morning" : "Evening";
        Content = Content + `<tr><td>${s.startingTime
            }</td > <td>${s.endingTime}</td><td>${Type}</td><td><button onclick="SubmitApplication(${s.id})" class="btn btn-sm btn-outline-primary">Apply </button></td></tr>`;
    }
    Content = Content + `</table >`;
    $('#modelBody').empty();
    $('#modelBody').append(Content);
    $('#exampleModal').modal();
}
function SubmitApplication(ShiftId) {
    window.location.href = `/ShiftApplication/Index?ShiftId=${ShiftId}`;
}