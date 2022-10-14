function selectSearchType(searchType) {
    const form = document.getElementById('mainForm');
    //let form =
    //var form =
    //alert(searchType.value);

    const searchTypeSelection = document.getElementById('searchTypeSelected');

    searchTypeSelection.value = 'C';

    form.submit();
}

function changeSearchForm(searchType) {
    // console.log(searchType.value);

    const searchQuery = document.getElementById('searchQuery');
    const searchGenreContainer = document.getElementById('searchGenreContainer');

    if (searchType.value === 'T' || searchType.value === 'D') {
        searchQuery.style.display = 'block';
        searchGenreContainer.style.display = 'none';
    } else {
        searchQuery.style.display = 'none';
        searchGenreContainer.style.display = 'block';
    }
}