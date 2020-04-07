

var Kitchen = {
    settings: {
        container: $('.calendar'),
        calendar: $('.front'),
        days: $('.weeks span'),
        form: $('.back'),
        input: $('.back input'),
        buttons: $('.back button')
    },

    init: function () {
        instance = this;
        settings = this.settings;
        this.bindUIActions();
    },

    swap: function (currentSide, desiredSide) {
        settings.container.toggleClass('flip');

        currentSide.fadeOut(900);
        currentSide.hide();

        desiredSide.show();
    },

    bindUIActions: function () {
        settings.days.on('click', function () {
            instance.swap(settings.calendar, settings.form);
            settings.input.focus();
        });

        settings.buttons.on('click', function () {
            instance.swap(settings.form, settings.calendar);
        });
    }
}

Kitchen.init();

monthNames = ["January", "February", "March", "April", "May", "June",
    "July", "August", "September", "October", "November", "December"
];

var d = new Date();

var adults = Math.floor(Math.random() * 30);

var kids = Math.floor(Math.random() * 30);

var guest = adults + kids;
