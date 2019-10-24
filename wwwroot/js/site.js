function Load() {
    var calendar = new HelloWeek({
        selector: '.hello-week',
        lang: 'en',
        langFolder: './dist/langs/',
        format: 'DD/MM/YYYY',
        weekShort: true,
        monthShort: false,
        multiplePick: false,
        defaultDate: null,
        todayHighlight: true,
        disablePastDays: true,
        disabledDaysOfWeek: null,
        disableDates: null,
        weekStart: 0, // week start on Sunday
        daysHighlight: null,
        daysSelected: null,
        range: false,
        rtl: false,
        locked: false,
        minDate: new Date(),
        maxDate: new Date(Date.now() + 12096e5),
        nav: ['◀', '▶'],
        onSelect: () => {
            updateInfo(
                calendar.getDays()[0]
            );
        }
    });
}
function updateInfo(SelectedDate) {
    SelectedDate = SelectedDate.replace(new RegExp('/', 'g'), '-');
    fetch(`/api/Shifts/${SelectedDate}`).then(res => res.json()).then(res => ShowModal(res, SelectedDate));

}

function ShowModal(source, date) {
    $('#exampleModalLabel').empty();
    $('#exampleModalLabel').append(`Shifts for ${date} `);
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
function ExportApplications() {
    TableToExcel.convert(document.getElementById("ApplicationsTable"));
}