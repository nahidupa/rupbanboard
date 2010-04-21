using System;
using System.Collections.Generic;
using Rupban.Core;
using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Services;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public class RupbanBoardPresenter: IRupbanBoardPresenter
    {
        private readonly IRupbanBoardController _rupbanBoardController;
        private readonly IRupbanBoardService _rupbanBoardService;

        public List<TemplateCollum> ColumnList { set; get; }

        public RupbanBoardPresenter(IRupbanBoardView view, IRupbanBoardController rupbanBoardController, IRupbanBoardService rupbanBoardService)
        {
            _rupbanBoardController = rupbanBoardController;
            _rupbanBoardService = rupbanBoardService;
            View = view;
            View.SetModel(this);
            ColumnList=_rupbanBoardService.GetTemplateCollumList();
        }

        public IRupbanBoardView View
        {
            get; set;
        }
    }
}