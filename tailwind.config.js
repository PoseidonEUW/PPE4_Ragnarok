const defaultTheme = require('tailwindcss/defaultTheme');

module.exports = {
    purge: [
        './vendor/laravel/framework/src/Illuminate/Pagination/resources/views/*.blade.php',
        './storage/framework/views/*.php',
        './resources/views/**/*.blade.php',
    ],

    theme: {

        extend: {
            fontFamily: {
                sans: ['Nunito', ...defaultTheme.fontFamily.sans],
                netflix:['Bebas Neue'],

            },
            width:{
                '96':'24rem',
            },

            opacity: {
                '0': '0',
                '15':'.15',
                '25': '.25',
                '50': '.5',
                '75': '.75',
                '10': '.1',
                '20': '.2',
                '30': '.3',
                '40': '.4',
                '50': '.5',
                '60': '.6',
                '70': '.7',
                '80': '.8',
                '90': '.9',
                '100': '1',
            },

            borderWidth: {
                DEFAULT: '1px',
                '0': '0',
                '2': '2px',
                '3': '3px',
                '4': '4px',
                '6': '6px',
                '8': '8px',
            },
        },
    },

    variants: {
        extend: {
            opacity: ['active'],
            transitionProperty: ['responsive', 'motion-safe', 'motion-reduce'],
        },
    },

    plugins: [require('@tailwindcss/forms')],
};
