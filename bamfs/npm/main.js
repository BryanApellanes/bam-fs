if (typeof require !== 'undefined' && require.main === module) {
    require('./bamfs').run(process.argv.slice(2));
}

