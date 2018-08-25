// formatting JS Date to C# Date
function formatDate(date) {
    var date1 = new Date();
    date = date1;

    var retDate = "";

    if (date.getDate() < 10)
        retDate += '0' + date.getDate() + ".";
    else
        retDate += date.getDate() + ".";
    if (date.getMonth() < 10)
        retDate += '0' + (date.getMonth() + 1) + ".";
    else
        retDate += (date.getMonth() + 1) + ".";
    retDate += date.getFullYear() + " ";


    retDate += date.getHours() + ":";
    if (date.getMinutes() < 10)
        retDate += "0" + date.getMinutes() + ":";
    else
        retDate += date.getMinutes() + ":";
    if (date.getSeconds() < 10)
        retDate += "0" + date.getSeconds();
    else
        retDate += date.getSeconds();

    return retDate;
}