namespace Kendo.Mvc.UI.Tests.Chart
{
    using System;
    using Kendo.Mvc.UI;
    using Kendo.Mvc.UI.Fluent;
    using Xunit;
    using System.Collections.Generic;

    public class ChartClientEventsBuilderTests
    {
        private readonly ChartClientEventsBuilder builder;
        private readonly IDictionary<string, object> clientEvents;
        private readonly Action emptyAction;
        private readonly Func<object, object> nullFunc;
        private readonly string handlerName;

        public ChartClientEventsBuilderTests()
        {
            clientEvents = new Dictionary<string, object>();
            builder = new ChartClientEventsBuilder(clientEvents);

            emptyAction = () => { };
            nullFunc = (o) => null;
            handlerName = "myHandler";
        }

        [Fact]
        public void DataBound_with_Func_should_set_InlineCodeBlock()
        {
            builder.DataBound(nullFunc);
            clientEvents["dataBound"].ShouldNotBeNull();
        }

        [Fact]
        public void DataBound_with_Func_should_return_builder()
        {
            builder.DataBound(nullFunc).ShouldBeType<ChartClientEventsBuilder>();
        }

        [Fact]
        public void DataBound_with_string_should_set_HandlerName()
        {
            builder.DataBound(handlerName);
            ((ClientEvent) clientEvents["dataBound"]).HandlerName.ShouldEqual(handlerName);
        }

        [Fact]
        public void DataBound_with_string_should_return_builder()
        {
            builder.DataBound(handlerName).ShouldBeType<ChartClientEventsBuilder>();
        }

        [Fact]
        public void SeriesClick_with_Func_should_set_InlineCodeBlock()
        {
            builder.SeriesClick(nullFunc);
            clientEvents["seriesClick"].ShouldNotBeNull();
        }

        [Fact]
        public void SeriesClick_with_Func_should_return_builder()
        {
            builder.SeriesClick(nullFunc).ShouldBeType<ChartClientEventsBuilder>();
        }

        [Fact]
        public void SeriesClick_with_string_should_set_HandlerName()
        {
            builder.SeriesClick(handlerName);
            ((ClientEvent) clientEvents["seriesClick"]).HandlerName.ShouldEqual(handlerName);
        }

        [Fact]
        public void SeriesClick_with_string_should_return_builder()
        {
            builder.SeriesClick(handlerName).ShouldBeType<ChartClientEventsBuilder>();
        }

        [Fact]
        public void SeriesHover_with_Func_should_set_InlineCodeBlock()
        {
            builder.SeriesHover(nullFunc);
            clientEvents["seriesHover"].ShouldNotBeNull();
        }

        [Fact]
        public void SeriesHover_with_Func_should_return_builder()
        {
            builder.SeriesHover(nullFunc).ShouldBeType<ChartClientEventsBuilder>();
        }

        [Fact]
        public void SeriesHover_with_string_should_set_HandlerName()
        {
            builder.SeriesHover(handlerName);
            ((ClientEvent) clientEvents["seriesHover"]).HandlerName.ShouldEqual(handlerName);
        }

        [Fact]
        public void SeriesHover_with_string_should_return_builder()
        {
            builder.SeriesHover(handlerName).ShouldBeType<ChartClientEventsBuilder>();
        }

        [Fact]
        public void AxisLabelClick_with_Func_should_set_InlineCodeBlock()
        {
            builder.AxisLabelClick(nullFunc);
            clientEvents["axisLabelClick"].ShouldNotBeNull();
        }

        [Fact]
        public void AxisLabelClick_with_Func_should_return_builder()
        {
            builder.AxisLabelClick(nullFunc).ShouldBeType<ChartClientEventsBuilder>();
        }

        [Fact]
        public void AxisLabelClick_with_string_should_set_HandlerName()
        {
            builder.AxisLabelClick(handlerName);
            ((ClientEvent)clientEvents["axisLabelClick"]).HandlerName.ShouldEqual(handlerName);
        }

        [Fact]
        public void AxisLabelClick_with_string_should_return_builder()
        {
            builder.AxisLabelClick(handlerName).ShouldBeType<ChartClientEventsBuilder>();
        }
    }
}
