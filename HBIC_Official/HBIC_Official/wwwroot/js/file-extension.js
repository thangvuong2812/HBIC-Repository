const checkFileType = (typeArr, fileName) => {
    const fileType = fileName.split(".").pop().toLowerCase();
    const lowerTypes = typeArr.map(o => o.toLowerCase());
    const isExist = lowerTypes.includes(fileType);
    if (isExist == false) {
        const message = `Vui lòng chọn tệp hình ảnh ${typeArr.toString().replaceAll(",",", ")}`;
        var modalEle = `<div class="modal fade" id="alertModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
              <div class="modal-dialog" role="document">
                <div class="modal-content">
                  <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Thông báo!</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                      <span aria-hidden="true">&times;</span>
                    </button>
                  </div>
                  <div class="modal-body">
                    <p class="text-danger">${message}</p>
                  </div>
                  <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Đóng</button>
                  </div>
                </div>
              </div>
            </div>`;
        const lengthEle = $('#alertModal').length;
       
        if (!lengthEle)
            $(modalEle).appendTo('body');
        $('#alertModal').modal('show');
    }
    return isExist;
}