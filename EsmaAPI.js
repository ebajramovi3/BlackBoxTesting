/** https://rickandmortyapi.com/api/character */

pm.test("Response status code is 200", function () {
  pm.response.to.have.status(200);
});

pm.test("Name is a non-empty string", function () {
    pm.response.json().results.forEach(function(result) {
        pm.expect(result.name).to.be.a('string').and.to.have.lengthOf.at.least(1, "Name should not be empty");
    });
});

pm.test("Info object contains expected keys", function () {
    pm.expect(pm.response.json().info).to.have.keys('count', 'pages', 'next', 'prev');
});

pm.test("Content-Type header is application/json", function () {
    pm.expect(pm.response.headers.get("Content-Type")).to.include("application/json");
});

pm.test("Url field is a valid URL", function () {
  const responseData = pm.response.json();
  
  pm.expect(responseData.results).to.be.an('array');
  responseData.results.forEach(function(result) {
    pm.expect(result.url).to.match(/^http(s)?:\/\/[a-zA-Z0-9-\.]+\.[a-zA-Z]{2,3}(\/\S*)?$/);
  });
});

/** https://rickandmortyapi.com/api */
pm.test('Response status code is 200', function () {
    pm.response.to.have.status(200);
})

pm.test('Response has the required fields - characters, locations, and episodes', function () {
    pm.expect(pm.response.json()).to.have.all.keys('characters', 'locations', 'episodes');
})

pm.test('Content-Type header is application/json', function () {
    pm.expect(pm.response.headers.get('Content-Type')).to.include('application/json');
})

pm.test('Characters, locations, and episodes are not empty', function () {
    pm.expect(pm.response.json().characters).to.not.be.empty;
    pm.expect(pm.response.json().locations).to.not.be.empty;
    pm.expect(pm.response.json().episodes).to.not.be.empty;
})

/** https://rickandmortyapi.com/api/episode/10,28 */
pm.test("Response status code is 200", function () {
  pm.response.to.have.status(200);
});


pm.test("Content type is application/json", function () {
    pm.expect(pm.response.headers.get("Content-Type")).to.include("application/json");
});


pm.test("Id field should exist and be a number", function () {
  const responseData = pm.response.json();
  
  pm.expect(responseData).to.be.an('array');
  responseData.forEach(function(episode) {
    pm.expect(episode.id).to.exist;
    pm.expect(episode.id).to.be.a('number');
  });
});


pm.test("Characters array is present and contains at least one element", function () {
    const responseData = pm.response.json();

    pm.expect(responseData).to.be.an('array');
    responseData.forEach(function(episode) {
        pm.expect(episode.characters).to.be.an('array').that.is.not.empty;
    });
});