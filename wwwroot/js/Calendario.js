window.CrearCalendario = (proyectos) => {

    var calendarioEl = document.getElementById('calendario');

    var eventos = proyectos.map(p => {
        return {
            id: p.id,
            title: p.titulo,
            start: p.fechaInicio,
            end: p.fechaFinalizacion ? p.fechaFinalizacion : p.fechaFinPrevista
        };
    });

    var calendar = new FullCalendar.Calendar(calendarioEl, {
        initialView: 'dayGridMonth',
        events: eventos
    });

    calendar.render();
};
