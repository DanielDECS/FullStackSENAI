var crypto = require('crypto');

function generateSalt() {
    return crypto.randomBytes(Math.ceil(length / 2))
        .toString('hex')
        .slice(0,16);
};

function sha512(password, salt) {
    var hash = crypto.createHmac('sha512', salt);
    hash.update(password);
    var hash = hash.digest('hex');
    return {
        salt,
        hash
    };
};

function genarateHash(password) {
    var salt = generateSalt(16);
    var passwordPlusSalt = sha512(password, salt);
    console.log('Senha Hash: ' + passwordPlusSalt.hash);
    console.log('Salt: ' + passwordPlusSalt.salt);
}