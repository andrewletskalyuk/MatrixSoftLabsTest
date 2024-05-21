const path = require('path');

module.exports = {
    mode: 'development',
    entry: './wwwroot/js/calendar.js',
    output: {
        filename: 'bundle.js',
        path: path.resolve(__dirname, 'wwwroot/dist')
    },
    module: {
        rules: [
            {
                test: /\.m?js$/,
                exclude: /(node_modules|bower_components)/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        presets: ['@babel/preset-env']
                    }
                }
            }
        ]
    },
    resolve: {
        alias: {
            '@fullcalendar/core': path.resolve(__dirname, 'node_modules/@fullcalendar/core'),
            '@fullcalendar/daygrid': path.resolve(__dirname, 'node_modules/@fullcalendar/daygrid'),
            '@fullcalendar/interaction': path.resolve(__dirname, 'node_modules/@fullcalendar/interaction')
        }
    }
};
