module.exports = {
    name: 'my-icons',
    fontHeight: 500,
    normalize: true,
    inputDir: 'svg',
    outputDir: '/tmp/maui-svg-ttf',
    fontTypes: ['ttf'],
    assetTypes: ['css', 'json', 'html'],
    formatOptions: {
        json: {
            indent: 2
        }
    },
    codepoints: {
        'globe': 57344, // decimal representation of 0xe000
    },
    getIconId: ({
        basename, // `string` - Example: 'foo';
        relativeDirPath, // `string` - Example: 'sub/dir/foo.svg'
        absoluteFilePath, // `string` - Example: '/var/icons/sub/dir/foo.svg'
        relativeFilePath, // `string` - Example: 'foo.svg'
        index // `number` - Example: `0`
    }) => {
        return basename;
    }
};
