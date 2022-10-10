function selectSearchType(searchType) {
    const form = document.getElementById('mainForm');
    //let form =
    //var form =
    //alert(searchType.value);

    const searchTypeSelection = document.getElementById('searchTypeSelected');

    searchTypeSelection.value = 'C';

    form.submit();
}