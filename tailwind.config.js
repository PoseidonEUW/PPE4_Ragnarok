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
            },
            width:{
                '96':'24rem',
            }
        },
    },

    variants: {
        extend: {
            opacity: ['disabled'],
            transitionProperty: ['responsive', 'motion-safe', 'motion-reduce'],
        },
    },

    plugins: [require('@tailwindcss/forms')],
};
