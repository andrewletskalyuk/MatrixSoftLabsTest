import { Calendar } from '@fullcalendar/core';
import dayGridPlugin from '@fullcalendar/daygrid';
import interactionPlugin from '@fullcalendar/interaction';

document.addEventListener('DOMContentLoaded', function () {
    var calendarEl = document.getElementById('calendar');
    if (calendarEl) {
        var calendar = new Calendar(calendarEl, {
            plugins: [dayGridPlugin, interactionPlugin],
            initialView: 'dayGridMonth',
            events: async function (fetchInfo, successCallback, failureCallback) {
                try {
                    let response = await fetch('/api/holiday/swedish-red-days');
                    let data = await response.json();
                    let events = data.map(holiday => ({
                        title: holiday.name,
                        start: holiday.date,
                        allDay: true
                    }));
                    successCallback(events);
                } catch (error) {
                    failureCallback(error);
                }
            }
        });
        calendar.render();
    }
});
